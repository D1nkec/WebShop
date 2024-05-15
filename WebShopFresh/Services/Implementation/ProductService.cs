using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
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
        public async Task<List<ProductViewModel>> GetProducts()
        {
            var products = await _context.Products.Include(y => y.Category).ToListAsync();
            if (!products.Any())
            {
                return new List<ProductViewModel>();
            }

            return products.Select(y => _mapper.Map<ProductViewModel>(y)).ToList();
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
            var dbo = await _context.Products.Include(y => y.Category).FirstOrDefaultAsync(y => y.Id == id);


            //Ova akcija označava proizvod kao nevažeći umjesto da se stvarno briše iz baze podataka.
            dbo.Valid = false;

            await _context.SaveChangesAsync();
            return _mapper.Map<ProductViewModel>(dbo);
        }



    }
}
