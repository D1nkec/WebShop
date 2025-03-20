using System.Security.Claims;
using System.Threading.Tasks;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;

namespace WebShopFresh.Services.Interface
{
    public interface IOrderService
    {
        Task<List<OrderViewModel>> GetOrders(ClaimsPrincipal user);
        Task<List<OrderViewModel>> GetOrders();
        Task<List<OrderViewModel>> GetOrders(ApplicationUser buyer);


        Task<OrderViewModel> GetOrder(long id);
     


        Task<OrderViewModel> CancelOrder(long id);


        Task<OrderViewModel> Order(OrderBinding model, ClaimsPrincipal user);
        Task<OrderViewModel> Order(OrderBinding model, ApplicationUser buyer);

        Task<OrderViewModel> UpdateOrder(OrderUpdateBinding model);
    


        Task<List<ProductViewModel>> GetProductItems(List<long> productItemIds);
    }
}
