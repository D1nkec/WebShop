using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Shared.Models.Base.OrderModels;

namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
   public class OrderBinding : OrderBase
    {
        public string? OrderAdress { get; set; }

        public List<OrderItemBinding>? OrderItems { get; set; }
    }
}
