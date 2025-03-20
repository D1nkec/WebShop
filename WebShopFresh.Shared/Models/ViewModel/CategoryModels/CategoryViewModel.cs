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
