using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopFresh.Shared.Models.Base.OrderModels;
using WebShopFresh.Shared.Models.ViewModel.AddressModels;
using WebShopFresh.Shared.Models.ViewModel.UserModel;


namespace WebShopFresh.Shared.Models.ViewModel.OrderModels
{
    public class OrderViewModel : OrderBase
    {
        [Display(Name = "Order Id")]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public ApplicationUserViewModel? Buyer { get; set; }
        public AddressViewModel? OrderAddress { get; set; }
        public List<OrderItemViewModel>? OrderItems { get; set; }
        [Required(ErrorMessage = "Total price is required.")]
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Total { get; set; }
    }
}
