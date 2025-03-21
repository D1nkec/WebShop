
namespace WebShopFresh.Shared.Models.Dto
{
    public class ProductFilterOptions
    {
        public string SearchString { get; set; }
        public string SortOrder { get; set; }
        public long? CategoryId { get; set; }
        public bool? Valid { get; set; } = true;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 9;
    }
}
