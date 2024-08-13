using WebShopFresh.Shared.Models.Binding.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.OrderModels;

namespace WebShopFresh.Services.Interface
{
    public interface IOrderService
    {
        Task<OrderViewModel> GetOrder(long id);
        Task<List<OrderViewModel>> GetOrders();
        Task<OrderViewModel> UpdateOrder(OrderUpdateBinding model);
    }
}