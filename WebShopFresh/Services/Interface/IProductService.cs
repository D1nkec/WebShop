using WebShopFresh.Shared.Models.Binding.ProductModels;
using WebShopFresh.Shared.Models.ViewModel.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> GetProduct(long id);
        Task<(List<ProductViewModel> products, List<CategoryViewModel> categories, int totalItems)> GetFilteredSortedProductsAndCategories(string searchString, string sortOrder, long? categoryId, bool? valid = true, int page = 1, int pageSize = 9);

        Task<ProductViewModel> AddProduct(ProductBinding model);
        Task<ProductViewModel> UpdateProduct(ProductUpdateBinding model);
        Task<ProductViewModel> DeleteProduct(long id);
    }
}





