using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> AddProduct(ProductBinding model);
        Task<List<ProductViewModel>> GetProducts();
        Task<ProductViewModel> GetProduct(long id);

        Task<ProductViewModel> DeleteProduct(long id);

        Task<ProductViewModel> UpdateProduct(ProductUpdateBinding model);
    }
}





