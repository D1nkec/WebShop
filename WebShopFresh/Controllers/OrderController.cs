using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.AddressModels;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.Dto;



namespace WebShopFresh.Controllers
{
    [Authorize(Roles = Roles.Buyer)]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IAccountService _accountService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController(IOrderService orderService, IAccountService accountService, IProductService productService, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _orderService = orderService;
            _accountService = accountService;
            _productService = productService;
            _mapper = mapper;
            _userManager = userManager;
        }



        public async Task<IActionResult> Order()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }
           
                var sessionOrderItems = HttpContext.Session.GetString("OrderItems");
                List<OrderItemBinding> existingOrderItems = sessionOrderItems != null
                    ? JsonConvert.DeserializeObject<List<OrderItemBinding>>(sessionOrderItems)
                    : new List<OrderItemBinding>();


            var userAddress = await _accountService.GetUserAddress(User);
                OrderBinding orderBinding = new OrderBinding()
                {
                    OrderAddress = userAddress != null ? _mapper.Map<AddressBinding>(userAddress) : new AddressBinding(),
                    OrderItems = existingOrderItems
                };

                return View(orderBinding);
            
        }



        [HttpPost]
        public async Task<IActionResult> Order(OrderBinding model)
        {
            var order = await _orderService.Order(model, User);
            return RedirectToAction("MyOrder", new {orderId = order.Id});
        }

        public async Task<IActionResult> MyOrder(long orderId)
        {
            var order = await _orderService.GetOrder(orderId);
            return View(order);
        }



        public async Task<IActionResult> MyOrders()
        {
            var orders = await _orderService.GetOrders(User);
            return View(orders);
        }


        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> CancelOrder(long orderId)
        {
            var model = await _orderService.CancelOrder(orderId);
            return RedirectToAction("MyOrders");
        }



        public async Task<IActionResult> Details(long id)
        {
            var product = await _productService.GetProduct(id);
            return View(product);
        }



        [HttpPost]
        public async Task<IActionResult> AddToOrderItem([FromBody] List<OrderItemBinding> orderItems)
        {
            var sessionOrderItems = HttpContext.Session.GetString("OrderItems");
            List<OrderItemBinding> existingOrderItems = sessionOrderItems != null ? JsonConvert.DeserializeObject<List<OrderItemBinding>>(sessionOrderItems) : new List<OrderItemBinding>();

            foreach (var orderItem in orderItems)
            {
                var existingItem = existingOrderItems.Find(item => item.ProductId == orderItem.ProductId);
                if (existingItem != null)
                {
                    existingItem.Quantity += orderItem.Quantity;
                }
                else
                {
                    existingOrderItems.Add(orderItem);
                }
            }

            HttpContext.Session.SetString("OrderItems", JsonConvert.SerializeObject(existingOrderItems));
            return Json(new { msg = "Ok" });

        }

    }
}
