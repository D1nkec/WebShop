using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.UserModel;
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public Address? OrderAddress { get; set; }
        public long? OrderAddressId { get; set; }
        public ApplicationUser? Buyer { get; set; }
        public string? BuyerId { get; set; }
        public ICollection<OrderItem>? OrderItems { get; set; }

        public void CalculateTotal()
        {
            if (OrderItems == null)
            {
                return;
            }

            Total = OrderItems.Select(y => y.CalculateTotal()).Sum();
        }
    }
}
