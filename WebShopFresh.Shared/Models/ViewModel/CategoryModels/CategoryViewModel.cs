using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopFresh.Shared.Models.Base.CategoryModels;
using WebShopFresh.Shared.Models.ViewModel.ProductViewModels;

namespace WebShopFresh.Shared.Models.ViewModel.CategoryModels
{
    public class CategoryViewModel : CategoryBase
    {
        public long Id { get; set; }

        public List<ProductViewModel>? Products { get; set; }
    }
}
