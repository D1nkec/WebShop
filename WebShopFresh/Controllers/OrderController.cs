using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
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
        private readonly ICommonService _commonService;
        private readonly UserManager<ApplicationUser> _userManager;
        private static string OrderItemSessionKey = "OrderItems";

        public OrderController(IOrderService orderService, IAccountService accountService, IProductService productService, ICommonService commonService, UserManager<ApplicationUser> userManager)
        {
            _orderService = orderService;
            _accountService = accountService;
            _productService = productService;
            _commonService = commonService;
            _userManager = userManager;
        }



        public async Task<IActionResult> Order()
        {
            var sessionOrderItems = HttpContext.Session.GetString(OrderItemSessionKey);
            List<OrderItemBinding> existingOrderItems = sessionOrderItems != null ?
                JsonSerializer.Deserialize<List<OrderItemBinding>>(sessionOrderItems) : new List<OrderItemBinding>();



            if (!existingOrderItems.Any())
            {
                var sessionFromDb = await _commonService.GetSessionItem<List<OrderItemBinding>>(OrderItemSessionKey, User);
                if(sessionFromDb != null)
                {
                    existingOrderItems = sessionFromDb;
                    HttpContext.Session.SetString(OrderItemSessionKey,JsonSerializer.Serialize(existingOrderItems));
                }
            }


            var respose = new OrderBinding
            {
                OrderItems = existingOrderItems,
                OrderAddress = await _accountService.GetUserAddress<AddressBinding>(User)
            };
            return View(respose);
        }



        [HttpPost]
        public async Task<IActionResult> Order(OrderBinding model)
        {
            var order = await _orderService.Order(model, User);
            HttpContext.Session.Remove(OrderItemSessionKey);
            await _commonService.RemoveFromSession(OrderItemSessionKey,User);

            return RedirectToAction("MyOrder", new {orderId = order.Id});
        }

        public async Task<IActionResult> MyOrder(long orderId)
        {
            var order = await _orderService.GetOrder(orderId);
            if (order == null)
            {
                return NotFound();
            }
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
            var order = await _orderService.CancelOrder(orderId);
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
            var sessionOrderItems = HttpContext.Session.GetString(OrderItemSessionKey);

            List<OrderItemBinding> existingOrderItems = sessionOrderItems != null ? JsonSerializer.Deserialize<List<OrderItemBinding>>(sessionOrderItems) : new List<OrderItemBinding>();

            foreach(var orderItem in orderItems)
            {
                var existingOrderItem = existingOrderItems.FirstOrDefault(item => item.ProductId == orderItem.ProductId);

                if(existingOrderItem != null)
                {
                    existingOrderItem.Quantity += orderItem.Quantity;
                }
                else
                {
                    existingOrderItems.Add(orderItem);
                }
            }
            await _commonService.AddSessionItem(OrderItemSessionKey, existingOrderItems, User);
            HttpContext.Session.SetString(OrderItemSessionKey,JsonSerializer.Serialize(existingOrderItems));

            return Json(existingOrderItems);
        }


    }
}
