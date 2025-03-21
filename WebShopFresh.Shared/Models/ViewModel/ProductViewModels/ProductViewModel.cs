using WebShopFresh.Shared.Models.Base.ProductModels;

namespace WebShopFresh.Shared.Models.ViewModel.ProductViewModels
{
    public class ProductViewModel : ProductBase
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
