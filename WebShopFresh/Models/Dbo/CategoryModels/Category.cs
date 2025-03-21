using System.ComponentModel.DataAnnotations;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.CategoryModels;


namespace WebShopFresh.Models.Dbo.CategoryModels
{
    public class Category : CategoryBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }
        public ICollection<Product>? Products { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }
    }
}
