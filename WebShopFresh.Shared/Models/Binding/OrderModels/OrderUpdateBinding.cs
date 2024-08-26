using WebShopFresh.Shared.Models.Base.OrderModels;



namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderUpdateBinding : OrderBase
    {
        public long Id { get; set; }

        public string? Address { get; set; }

        public List<OrderItemUpdateBinding>? OrderItemIds { get; set; }
    }
}
