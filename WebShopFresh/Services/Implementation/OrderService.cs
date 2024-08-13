using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;

namespace WebShopFresh.Services.Implementation
{
    public class OrderService : IOrderService

    {
        private ApplicationDbContext _context;
        private IMapper _mapper;


        public OrderService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }





        public async Task<List<OrderViewModel>> GetOrders()
        {
            var dbo = await _context.Orders
                                    .Include(y => y.OrderItems)
                                    .Where(y => y.Valid)
                                    .ToListAsync();

            return dbo.Select(y => _mapper.Map<OrderViewModel>(y)).ToList();

        }




        public async Task<OrderViewModel> GetOrder(long id)
        {
            var dbo = await _context.Orders.Include(y => y.OrderItems).FirstOrDefaultAsync(y => y.Id == id);

            return _mapper.Map<OrderViewModel>(dbo);
        }


        public async Task<OrderViewModel> UpdateOrder(OrderUpdateBinding model)
        {
            var dbo = await _context.Orders.Include(y => y.OrderItems).FirstOrDefaultAsync(y => y.Id == model.Id);
            _mapper.Map(model, dbo);

            await _context.SaveChangesAsync();

            return _mapper.Map<OrderViewModel>(dbo);
        }






    }
}
