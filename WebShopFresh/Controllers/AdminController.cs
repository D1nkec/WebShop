using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebShopFresh.Data;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;

namespace WebShopFresh.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public AdminController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }



        public async Task<IActionResult> Index()
        {
            // NO VIEW
            var categories = await _categoryService.GetCategories();
            return View(categories);
        }



      /// <summary>
        /// CREATE CATEGORY
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> CreateCategory()
        {

            //NO VIEW
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryBinding model)
        {
            await _categoryService.AddCategory(model);
            return RedirectToAction("Index");
        }

      /// <summary>
        /// CREATE PRODUCT
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<IActionResult> CreateProduct(long categoryId)
        {
            var model = new ProductBinding
            {
                CategoryId = categoryId
            };
            // NO VIEW
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductBinding model)
        {
            await _productService.AddProduct(model);
            return RedirectToAction("ProductDetails", new { id = model.CategoryId });
        }

      /// <summary>
      /// DETAILS - CATEGORY
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        public async Task<IActionResult> CategoryDetails(long id)
        {
            // NO VIEW
            var category = await _categoryService.GetCategory(id);
            return View(category);
        }

      /// <summary>
      /// DETAILS - PRODUCT
      /// </summary>
      /// <param name="id"></param>
      /// <returns></returns>
        public async Task<IActionResult> ProductDetails(long id)
        {
            var product = await _productService.GetProduct(id);
            return View(product);
        }

      /// <summary>
        /// EDIT PRODUCT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> EditProduct(long id)
        {
            //NO VIEW
            var model = await _productService.GetProduct(id);
            var response = _mapper.Map<ProductUpdateBinding>(model);
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductUpdateBinding model)
        {
            var response = await  _productService.UpdateProduct(model);
            return RedirectToAction("Details", new { id = response.CategoryId });
        }

      /// <summary>
        /// EDIT CATEGORY
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> EditCategory(long id)
        {
            //NO VIEW
            var model = await _categoryService.GetCategory(id);
            var response = _mapper.Map<CategoryUpdateBinding>(model);
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryUpdateBinding model)
        {
            _categoryService.UpdateCategory(model);
            return RedirectToAction("Index");
        }

      /// <summary>
        /// DELETE PRODUCT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> DeleteProduct(long id)
        {
            var response = await _productService.DeleteProduct(id);
            return RedirectToAction("ProductDetails", new {id = response.CategoryId});
        }

      /// <summary>
        /// DELETE CATEGORY
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> DeleteCategory(long id)
        {
            await _categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }



    }
}
