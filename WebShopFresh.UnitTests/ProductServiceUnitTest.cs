using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;
using Xunit.Sdk;

using Microsoft.AspNetCore.Http;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.UnitTests
{
   public class ProductServiceUnitTest : WebShopSetup
    {
        private readonly IProductService _productService;

        public ProductServiceUnitTest()
        {
            _productService = GetProductService();
        }



        [Fact] 
        public async void AddProductItem_AddsNewEntityToDb_ReturnsViewModel()
        {
            var response = await _productService.AddProduct(new ProductBinding
            {
               Description = TestString,
               Name = TestString,
               Price = 12613,
               CategoryId = Categories[1].Id,  
               Quantity = 10
            });

            Assert.NotNull(response);
            
        }

    }
}
