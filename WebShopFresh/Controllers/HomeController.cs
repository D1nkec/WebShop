using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebShopFresh.Models;
using WebShopFresh.Services.Interface;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.ViewModel;

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



        public async Task<IActionResult> Products(bool? valid = true)
        {
            var products = await _productService.GetProducts(valid);
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
