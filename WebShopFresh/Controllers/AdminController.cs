using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;
using System.Threading.Tasks;

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




        /// <summary>
        /// Displays details of a specific product.
        /// </summary>
        public async Task<IActionResult> ProductDetails(long id)
        {
            var product = await _productService.GetProduct(id);
            return View(product);
        }




        /// <summary>
        /// Displays a list of products.
        /// </summary>
        public async Task<IActionResult> Products(bool? valid = true)
        {
            var products = await _productService.GetProducts(valid);
            return View(products);
        }
    


    /// <summary>
    /// Displays a list of categories.
    /// </summary>
    public async Task<IActionResult> Categories(bool? valid = true)
        {
            var categories = await _categoryService.GetCategories(valid);
            return View(categories);
        }




        /// <summary>
        /// Displays a form to create a new product.
        /// </summary>
        public IActionResult CreateProduct()
        {
            return View();
        }




        /// <summary>
        /// Handles the submission of the new product form.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductBinding model)
        {
            await _productService.AddProduct(model);
            return RedirectToAction("Products");
        }




        /// <summary>
        /// Displays a form to edit an existing product.
        /// </summary>
        public async Task<IActionResult> EditProduct(long id)
        {
            var model = await _productService.GetProduct(id);
            var response = _mapper.Map<ProductUpdateBinding>(model);
            return View(response);
        }




        /// <summary>
        /// Handles the submission of the product edit form.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductUpdateBinding model)
        {
            await _productService.UpdateProduct(model);
            return RedirectToAction("Products");
        }




        /// <summary>
        /// Displays a form to create a new category.
        /// </summary>
        public IActionResult CreateCategory()
        {
            return View();
        }



        /// <summary>
        /// Handles the submission of the new category form.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryBinding model)
        {
            await _categoryService.AddCategory(model);
            return RedirectToAction("Categories");
        }




        /// <summary>
        /// Displays details of a specific category.
        /// </summary>
        public async Task<IActionResult> CategoryDetails(long id)
        {
            var category = await _categoryService.GetCategory(id);
            return View(category);
        }



        /// <summary>
        /// Displays a form to edit an existing category.
        /// </summary>
        public async Task<IActionResult> EditCategory(long id)
        {
            var model = await _categoryService.GetCategory(id);
            var response = _mapper.Map<CategoryUpdateBinding>(model);
            return View(response);
        }




        /// <summary>
        /// Handles the submission of the category edit form.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryUpdateBinding model)
        {
            await _categoryService.UpdateCategory(model);
            return RedirectToAction("Categories");
        }




        /// <summary>
        /// Deletes a product.
        /// </summary>
        public async Task<IActionResult> DeleteProduct(long id)
        {
            await _productService.DeleteProduct(id);
            return RedirectToAction("Products");
        }




        /// <summary>
        /// Deletes a category.
        /// </summary>
        public async Task<IActionResult> DeleteCategory(long id)
        {
            await _categoryService.DeleteCategory(id);
            return RedirectToAction("Categories");
        }



    }
}
