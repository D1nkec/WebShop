using WebShopFresh.Shared.Models.Base.OrderModels;
using WebShopFresh.Shared.Models.Binding.AddressModels;

namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderUpdateBinding : OrderBase
    {
        public long Id { get; set; }
        public AddressUpdateBinding? OrderAddress { get; set; }
        public List<OrderItemUpdateBinding>? OrderItemIds { get; set; }
    }
}
