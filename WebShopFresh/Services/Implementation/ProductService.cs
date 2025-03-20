using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.CategoryModels;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.ProductModels;
using WebShopFresh.Shared.Models.Dto;
using WebShopFresh.Shared.Models.ViewModel.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Implementation
{
    public class ProductService : IProductService
    {
       
        private readonly ApplicationDbContext _context;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private AppSettings _appSettings;
        private ApplicationDbContext context;
        private object value;
        private IMapper mapper;

        public ProductService(ApplicationDbContext context, ICategoryService categoryService, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _categoryService = categoryService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public ProductService(ApplicationDbContext context, object value, IMapper mapper)
        {
            this.context = context;
            this.value = value;
            this.mapper = mapper;
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
            var dbo = await _context.Products.Include(y => y.Category).FirstOrDefaultAsync(y => y.Id == id);

            var productViewModel = _mapper.Map<ProductViewModel>(dbo);

            if (dbo?.Category != null)
            {
                productViewModel.CategoryName = dbo.Category.Name;
            }

            return productViewModel;
        }



        /// <summary>
        /// GET PRODUCTS
        /// </summary>
        /// <returns></returns>
        public async Task<(List<ProductViewModel> products, List<CategoryViewModel> categories, int totalItems)> GetFilteredSortedProductsAndCategories(
      string searchString, string sortOrder, long? categoryId, bool? valid = true, int page = 1, int pageSize = 9)
        {
            // Get all products with category inclusion
            var productsQuery = _context.Products
                                        .Include(y => y.Category)
                                        .Where(y => y.Valid == valid);

            // Apply filters
            if (!string.IsNullOrEmpty(searchString))
            {
                productsQuery = productsQuery.Where(x => EF.Functions.Like(x.Name, $"%{searchString}%"));
            }

            if (categoryId.HasValue)
            {
                productsQuery = productsQuery.Where(x => x.CategoryId == categoryId.Value);
            }

            // Apply sorting
            switch (sortOrder)
            {
                case "name_desc":
                    productsQuery = productsQuery.OrderByDescending(p => p.Name);
                    break;
                case "price_desc":
                    productsQuery = productsQuery.OrderByDescending(p => p.Price);
                    break;
                case "price_asc":
                    productsQuery = productsQuery.OrderBy(p => p.Price);
                    break;
                default:
                    productsQuery = productsQuery.OrderBy(p => p.Name);
                    break;
            }

            // Get total number of items for pagination
            int totalItems = await productsQuery.CountAsync();

            // Apply pagination (skip and take based on page and pageSize)
            var products = await productsQuery.Skip((page - 1) * pageSize)
                                              .Take(pageSize)
                                              .ToListAsync();

            // Get categories (this doesn't depend on pagination)
            var categories = await _categoryService.GetCategories(valid: true);

            // Map entities to view models
            var productViewModels = products.Select(y => _mapper.Map<ProductViewModel>(y)).ToList();
            var categoryViewModels = categories.Select(y => _mapper.Map<CategoryViewModel>(y)).ToList();

            return (productViewModels, categoryViewModels, totalItems);
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