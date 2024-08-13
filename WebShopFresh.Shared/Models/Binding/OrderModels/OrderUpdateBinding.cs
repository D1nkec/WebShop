using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Shared.Models.Base.OrderModels;

namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderUpdateBinding : OrderBase
    {
        public long Id { get; set; }

        public string? Adress { get; set; }

        public List<OrderItemUpdateBinding>? OrderItemIds { get; set; }
    }
}
