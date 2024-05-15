using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Shared.Models.Base;

namespace WebShopFresh.Shared.Models.ViewModel
{
    public class CategoryViewModel : CategoryBase
    {
        public long Id { get; set; }

        public List<ProductViewModel>? Products { get; set; }
    }
}
