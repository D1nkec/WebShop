using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using WebShopFresh.Models;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Dto;



namespace WebShopFresh.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
     
        
        public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryService categoryService, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
            _appSettings = appSettings.Value;



        }



        public async Task<IActionResult> Products(string searchString, string sortOrder, long? categoryId, bool? valid = true, int page = 1)
        {
            const int pageSize = 9; // Define how many products per page
            var (products, categories, totalItems) = await _productService.GetFilteredSortedProductsAndCategories(searchString, sortOrder, categoryId, valid, page, pageSize);

            // Passing the selected categoryId to the view for highlighting the active category button
            ViewBag.Categories = categories;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentCategoryId"] = categoryId;  // Pass the selected categoryId

            // Pagination info
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);  // Total pages
            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;

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
