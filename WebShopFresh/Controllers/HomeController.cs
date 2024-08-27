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
        private readonly ICategoryService _categoryService;
        
        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService; 
        }



        public async Task<IActionResult> Products(string searchString, string sortOrder, long? categoryId, bool? valid = true)
        {
            // Call ProductService method to get filtered, sorted products, and categories
            var (products, categories) = await _productService.GetFilteredSortedProductsAndCategories(searchString, sortOrder, categoryId, valid);

            // Pass filtered and sorted products to the view
            ViewBag.Categories = categories;
            return View(products);
        }


        public async Task<IActionResult> Product(long id)
        {
            var product = await _productService.GetProduct(id);
            return PartialView("_ProductPartial", product);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
