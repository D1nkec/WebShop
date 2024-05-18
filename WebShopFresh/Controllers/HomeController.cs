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
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.AspNetCore.Identity;

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


        public async Task<IActionResult> Products(string searchString, string sortOrder, bool? valid = true)
        {
            var products = await _productService.GetProducts(valid);

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(x => x.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["PriceSortParam"] = sortOrder == "price_asc" ? "price_desc" : "price_asc";
            ViewData["CurrentFilter"] = searchString;

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(p => p.Name).ToList();
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price).ToList();
                    break;
                case "price_asc":
                    products = products.OrderBy(p => p.Price).ToList();
                    break;
                default:
                    products = products.OrderBy(p => p.Name).ToList();
                    break;
            }

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
