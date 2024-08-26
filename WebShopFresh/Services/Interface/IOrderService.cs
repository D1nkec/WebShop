using System.Security.Claims;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;



namespace WebShopFresh.Services.Interface
{
    public interface IOrderService
    {
        Task<OrderViewModel> CancelOrder(long id);
        Task<OrderViewModel> GetOrder(long id);
        Task<List<OrderViewModel>> GetOrders();
        Task<List<OrderViewModel>> GetOrders(ApplicationUser buyer);
        Task<List<OrderViewModel>> GetOrders(ClaimsPrincipal user);
        Task<List<ProductViewModel>> GetProductItems(List<long> productItemIds);
        Task<OrderViewModel> Order(OrderBinding model, ApplicationUser buyer);
        Task<OrderViewModel> Order(OrderBinding model, ClaimsPrincipal user);
        Task<OrderViewModel> UpdateOrder(OrderUpdateBinding model);
    }
}