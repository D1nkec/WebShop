using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.OrderModels;

namespace WebShopFresh.Models.Dbo.OrderModels
{
    public class Order : OrderBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }



        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Total { get; set; }
        public string? OrderAddress { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }
        public void CalculateTotal()
        {
            if(OrderItems == null)
            {
            return; 
            }

            Total = OrderItems.Select(y => y.CalculateTotal()).Sum();
        }
    }
}
