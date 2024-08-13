using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopFresh.Shared.Models.Base.OrderModels;




namespace WebShopFresh.Shared.Models.ViewModel.OrderModels
{
    public class OrderViewModel : OrderBase
    {
        [Display(Name = "Id narudžbe")]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string? OrderAddress { get; set; }
        public List<OrderItemViewModel>? OrderItems { get; set; }


        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(7, 2)")]
        [Display(Name = "Ukupno")]
        public decimal Total { get; set; }
    }
}
