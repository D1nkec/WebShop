using WebShopFresh.Shared.Models.Base.OrderModels;


namespace WebShopFresh.Shared.Models.ViewModel.OrderModels
{
    public class OrderItemViewModel : OrderItemBase
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
    }
}
