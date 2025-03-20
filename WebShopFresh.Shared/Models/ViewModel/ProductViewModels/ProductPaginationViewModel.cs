using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.ViewModel.ProductViewModels
{
    public class ProductPaginationViewModel
    {
        public int TotalRecords { get; set; }
        public int Rows { get; set; }
        public List<ProductViewModel> Products { get; set; }
    }
}
