using WebShopFresh.Shared.Models.Base.OrderModels;



namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderBinding : OrderBase
    {
        public string? OrderAddress { get; set; }
        public List<OrderItemBinding>? OrderItems { get; set; }
    }
}
