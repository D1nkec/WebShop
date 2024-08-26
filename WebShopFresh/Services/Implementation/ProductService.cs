using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.ProductModels;
using WebShopFresh.Shared.Models.ViewModel.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Implementation
{
    public class ProductService : IProductService
    {
       
        private readonly ApplicationDbContext _context;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDbContext context, ICategoryService categoryService, IMapper mapper)
        {
            _context = context;
            _categoryService = categoryService;
            _mapper = mapper;
        }



        /// <summary>
        /// CREATE PRODUCT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ProductViewModel> AddProduct(ProductBinding model)
        {
            var dbo = _mapper.Map<Product>(model);

            _context.Products.Add(dbo);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductViewModel>(dbo);
        }



        /// <summary>
        /// GET PRODUCT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProductViewModel> GetProduct(long id)
        {
            var dbo = await _context.Products.FindAsync(id);
            return _mapper.Map<ProductViewModel>(dbo);
        }



        /// <summary>
        /// GET PRODUCTS
        /// </summary>
        /// <returns></returns>
        public async Task<(List<ProductViewModel> products, List<CategoryViewModel> categories)> GetFilteredSortedProductsAndCategories(string searchString, string sortOrder, long? categoryId, bool? valid = true)
        {
    // Get all products
    var products = await _context.Products
                                 .Include(y => y.Category)
                                 .Where(y => y.Valid == valid)
                                 .ToListAsync();

    // Apply filters
    if (!string.IsNullOrEmpty(searchString))
    {
        products = products.Where(x => x.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    if (categoryId.HasValue)
    {
        products = products.Where(x => x.CategoryId == categoryId.Value).ToList();
    }

    // Apply sorting
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

    // Get categories
    var categories = await _categoryService.GetCategories(valid: true);

    // Map entities to view models
    var productViewModels = products.Select(y => _mapper.Map<ProductViewModel>(y)).ToList();
    var categoryViewModels = categories.Select(y => _mapper.Map<CategoryViewModel>(y)).ToList();

    return (productViewModels, categoryViewModels);
}



        /// <summary>
        /// UPDATE PRODUCT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ProductViewModel> UpdateProduct(ProductUpdateBinding model)
        {
            var dbo = await _context.Products.FindAsync(model.Id);
            _mapper.Map(model, dbo);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductViewModel>(dbo);
        }



        /// <summary>
        /// DELETE PRODUCT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ProductViewModel> DeleteProduct(long id)
        {
            var dbo = await _context.Products
                .Include(y => y.Category)
                .FirstOrDefaultAsync(y => y.Id == id);

            dbo.Valid = false;
            await _context.SaveChangesAsync();

            return _mapper.Map<ProductViewModel>(dbo);
        }

    }
}


