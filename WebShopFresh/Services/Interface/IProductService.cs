using WebShopFresh.Models.Dbo;
using WebShopFresh.Shared.Models.Binding;
using WebShopFresh.Shared.Models.ViewModel;

namespace WebShopFresh.Services.Interface
{
    public interface IProductService
    {
        Task<ProductViewModel> GetProduct(long id);
        Task<List<ProductViewModel>> GetProducts(bool? valid);
        Task<ProductViewModel> AddProduct(ProductBinding model);
        Task<ProductViewModel> UpdateProduct(ProductUpdateBinding model);
        Task<ProductViewModel> DeleteProduct(long id);

        
    }
}





