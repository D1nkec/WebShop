using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.Binding.OrderModels
{
    public class OrderItemBinding
    {
        public decimal Quantity { get; set; }
        public long? ProductId { get; set; }
    }
}
