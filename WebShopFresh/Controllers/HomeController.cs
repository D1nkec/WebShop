using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShopFresh.Models;
using WebShopFresh.Services.Interface;

namespace WebShopFresh.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Products()
        {
            //NO VIEW
            var products = await _productService.GetProducts();
            return View(products);
        }
       
        public async Task<IActionResult> Product(long id)
        {
            var product = await _productService.GetProduct(id);
            return View(product);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
