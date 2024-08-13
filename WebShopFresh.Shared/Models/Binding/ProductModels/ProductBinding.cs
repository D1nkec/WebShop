using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Shared.Models.Base.ProductModels;

namespace WebShopFresh.Shared.Models.Binding.ProductModels
{
    public class ProductBinding : ProductBase
    {

        public long? CategoryId { get; set; }
    }
}
