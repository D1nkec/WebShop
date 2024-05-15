using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;

namespace WebShopFresh.UnitTests
{
    public class CategoryServiceUnitTest : WebShopSetup
    {
        private readonly ICategoryService _categoryService;

        public CategoryServiceUnitTest()
        {
            _categoryService = GetCategoryService();
        }



        //[Fact]
        //public async void GetCategories_FetchesAllCategoriesBasedOnSearch_ReturnsList()
        //{
        //    var response = await _categoryService.GetCategories();

        //    Assert.NotEmpty(response);
        //    Assert.Single(response);

        //    response = await _categoryService.GetCategories();

        //    Assert.NotEmpty(response);
        //    Assert.Equal(30, response.Count());
        //}


        [Fact]
        public async void AddCategory_AddsNewEntityToDb_ReturnsViewModel()
        {
            var response = await _categoryService.AddCategory(new CategoryBinding
            {
               Name = TestString,
               Description = TestString,
            });

            Assert.NotNull(response);
            Assert.Equal(TestString, response.Description);
            Assert.Equal(TestString, response.Name);

           response = await _categoryService.GetCategory(response.Id);
            Assert.NotNull(response);
        }


       [Fact]
       public async void DeleteCategory_DeletesEntityFromDb_ValidatesIfItemIsNull()
        {
            var deletedId = Categories[12].Id;
            await _categoryService.DeleteCategory(deletedId);

            var allItems = await _categoryService.GetCategories();

            Assert.Null(allItems.FirstOrDefault(y => y.Id == deletedId));
        }




    }
}
