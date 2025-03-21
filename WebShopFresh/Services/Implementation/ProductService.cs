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
        public async Task<(List<ProductViewModel> products, List<CategoryViewModel> categories, int totalItems)>
              GetFilteredSortedProductsAsync(ProductFilterOptions options)
        {
            try
            {
                var productsQuery = _context.Products
                                            .Include(y => y.Category)
                                            .Where(y => y.Valid == options.Valid);

                if (!string.IsNullOrEmpty(options.SearchString))
                {
                    productsQuery = productsQuery.Where(x => EF.Functions.Like(x.Name, $"%{options.SearchString}%"));
                }

                if (options.CategoryId.HasValue)
                {
                    productsQuery = productsQuery.Where(x => x.CategoryId == options.CategoryId.Value);
                }

                productsQuery = options.SortOrder switch
                {
                    "name_desc" => productsQuery.OrderByDescending(p => p.Name),
                    "price_desc" => productsQuery.OrderByDescending(p => p.Price),
                    "price_asc" => productsQuery.OrderBy(p => p.Price),
                    _ => productsQuery.OrderBy(p => p.Name),
                };

                int totalItems = await productsQuery.CountAsync();
                var products = await productsQuery.Skip((options.Page - 1) * options.PageSize)
                                                  .Take(options.PageSize)
                                                  .ToListAsync();

                var categories = await _categoryService.GetCategories(valid: true);
                var productViewModels = products.Select(y => _mapper.Map<ProductViewModel>(y)).ToList();
                var categoryViewModels = categories.Select(y => _mapper.Map<CategoryViewModel>(y)).ToList();

                return (productViewModels, categoryViewModels, totalItems);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching products: {ex.Message}");
                return (new List<ProductViewModel>(), new List<CategoryViewModel>(), 0);
            }
         
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