using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopFresh.Models.Dbo.ProductModels;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.OrderModels;

namespace WebShopFresh.Models.Dbo.OrderModels
{
    public class OrderItem : OrderItemBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }

        public Product? Product { get; set; }
        public long? ProductId { get; set; }

        public decimal CalculateTotal()
        {
            return Price * Quantity;
        }
    }
}
