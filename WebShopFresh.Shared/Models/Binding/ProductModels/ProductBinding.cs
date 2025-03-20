using WebShopFresh.Shared.Models.Base.ProductModels;

namespace WebShopFresh.Shared.Models.Binding.ProductModels
{
    public class ProductBinding : ProductBase
    {
        public long? CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
