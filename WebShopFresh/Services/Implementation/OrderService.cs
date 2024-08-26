using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.OrderModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.Dto;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public OrderService(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }



        public async Task<List<ProductViewModel>> GetProductItems(List<long> productItemIds)
        {
            var dbo = await _context.Products.Where(y => productItemIds.Contains(y.Id)).ToListAsync();

            return dbo.Select(y => _mapper.Map<ProductViewModel>(y)).ToList();

        }



        public async Task<OrderViewModel> Order(OrderBinding model, ClaimsPrincipal user)
        {
            var applicationUser = await _userManager.GetUserAsync(user);
            return await Order(model, applicationUser);

        }



        public async Task<List<OrderViewModel>> GetOrders()
        {
            var dbo = await _context.Orders
                                    .Include(y => y.Buyer)
                                    .Include(y => y.OrderItems)
                                    .Where(y => y.Valid)
                                    .ToListAsync();

            return dbo.Select(y => _mapper.Map<OrderViewModel>(y)).ToList();

        }



        public async Task<List<OrderViewModel>> GetOrders(ClaimsPrincipal user)
        {
            var applicationUser = await _userManager.GetUserAsync(user);
            var role = await _userManager.GetRolesAsync(applicationUser);

            switch (role[0])
            {
                case Roles.Admin:
                    return await GetOrders();
                case Roles.Buyer:
                    return await GetOrders(applicationUser);
                default:
                    throw new NotImplementedException($"{role[0]} isn't implemented in get orders!");

            }
        }


        public async Task<List<OrderViewModel>> GetOrders(ApplicationUser buyer)
        {
            var dbo = await _context.Orders
                .Include(y => y.Buyer)
                 .Include(y => y.OrderItems)
                .Include(y => y.OrderAddress)
                .Where(y => y.Valid && y.BuyerId == buyer.Id)
                .ToListAsync();

            return dbo.Select(y => _mapper.Map<OrderViewModel>(y)).ToList();
        }



        public async Task<OrderViewModel> GetOrder(long id)
        {
            var dbo = await _context.Orders
                .Include(y => y.Buyer)
                 .Include(y => y.OrderItems)
                .Include(y => y.OrderAddress)
                .FirstOrDefaultAsync(y => y.Id == id);
            return _mapper.Map<OrderViewModel>(dbo);
        }



        public async Task<OrderViewModel> UpdateOrder(OrderUpdateBinding model)
        {
            var dbo = await _context.Orders
                .Include(y => y.OrderItems)
                .Include(y => y.OrderAddress)
                .FirstOrDefaultAsync(y => y.Id == model.Id);
            _mapper.Map(model, dbo);
            await _context.SaveChangesAsync();

            return _mapper.Map<OrderViewModel>(dbo);
        }



        public async Task<OrderViewModel> CancelOrder(long id)
        {
            var dbo = await _context.Orders
                .Include(y => y.OrderItems)
                .ThenInclude(y => y.Product)
                .FirstOrDefaultAsync(y => y.Id == id);

            var productItems = _context.Products
                .Where(y => dbo.OrderItems.Select(y => y.ProductId).Contains(y.Id)).ToList();


            foreach (var product in dbo.OrderItems)
            {
                var target = productItems.FirstOrDefault(y => product.ProductId == y.Id);
                if (target != null)
                {
                    target.Quantity += product.Quantity;
                }
            }

            dbo.Valid = false;
            await _context.SaveChangesAsync();
            return _mapper.Map<OrderViewModel>(dbo);
        }



        public async Task<OrderViewModel> Order(OrderBinding model, ApplicationUser buyer)
        {
            var dbo = _mapper.Map<Order>(model);
            var productItems = _context.Products
                .Where(y => model.OrderItems.Select(y => y.ProductId).Contains(y.Id)).ToList();


            foreach (var product in dbo.OrderItems)
            {
                var target = productItems.FirstOrDefault(y => product.ProductId == y.Id);
                if (target != null)
                {
                    target.Quantity -= product.Quantity;
                    product.Price = target.Price;
                }
            }


            dbo.Buyer = buyer;
            dbo.CalculateTotal();

            _context.Orders.Add(dbo);
            await _context.SaveChangesAsync();
            return _mapper.Map<OrderViewModel>(dbo);








        }

    }
}
