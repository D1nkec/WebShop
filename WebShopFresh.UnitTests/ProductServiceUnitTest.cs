using WebShopFresh.Services.Interface;

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
            var response = await _productService.AddProduct(new Shared.Models.Binding.ProductModels.ProductBinding
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
