using WebShopFresh.Shared.Models.Base.ProductModels;



namespace WebShopFresh.Shared.Models.Binding.ProductModels
{
    public class ProductUpdateBinding : ProductBase
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
