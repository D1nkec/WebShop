using System.ComponentModel.DataAnnotations;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base;

namespace WebShopFresh.Models.Dbo
{
    public class Product : ProductBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }

        public Category Category { get; set; }
        public long? CategoryId { get; set; }

        public DateTime Created { get; set ; }
        public DateTime Updated { get ; set; }
        public bool Valid { get; set ; }
    }
}
