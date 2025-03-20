using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.ViewModel.ProductViewModels
{
    public class PaginationViewModel<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;

        public int MyProperty { get; set; }
    }

}
