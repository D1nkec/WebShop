using WebShopFresh.Shared.Models.Base.OrderModels;
using WebShopFresh.Shared.Models.Binding.AddressModels;



namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderBinding : OrderBase
    {
       public AddressBinding? OrderAddress { get; set; }    
        public List<OrderItemBinding>? OrderItems { get; set; }
    }
}
