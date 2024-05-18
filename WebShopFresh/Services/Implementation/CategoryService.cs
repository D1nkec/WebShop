using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoryService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// ADD CATEGORY
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> AddCategory(CategoryBinding model)
        {
            var dbo = _mapper.Map<Category>(model);

            _context.Categories.Add(dbo);
            await _context.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(dbo);
        }



        /// <summary>
        /// GET CATEGORIES
        /// </summary>
        /// <param name="valid"></param>
        /// <returns></returns>
        public async Task<List<CategoryViewModel>> GetCategories(bool? valid = true)
        {
            var dbos = await _context.Categories.Include(y => y.Products)
                                                .Where(y => y.Valid == valid)
                                                .ToListAsync();

            return dbos.Select(y => _mapper.Map<CategoryViewModel>(y)).ToList();
        }



        /// <summary>
        /// GET CATEGORY
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> GetCategory(long id)
        {
            var dbo = await _context.Categories.Include(y => y.Products.Where(item => item.Valid))
                                               .FirstOrDefaultAsync(y => y.Id == id);

            dbo.Products = dbo.Products.Where(y => y.Valid).ToList();

            return _mapper.Map<CategoryViewModel>(dbo);
        }



        /// <summary>
        /// UPDATE CATEGORY
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> UpdateCategory(CategoryUpdateBinding model)
        {
            var dbo = await _context.Categories.FindAsync(model.Id);
            _mapper.Map(model, dbo);
            await _context.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(dbo);
        }

       

        /// <summary>
        /// DELETE CATEGORY
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CategoryViewModel> DeleteCategory(long id)
        {
            var dbo = await _context.Categories.FindAsync(id);
            dbo.Valid = false;
            await _context.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(dbo);
        }


    }
}
