using System.ComponentModel.DataAnnotations;

namespace WebShopFresh.Shared.Models.Base.OrderModels
{
    public abstract class OrderBase
    {
        [Display(Name ="Message")]
        public string? Message { get; set; }
    }
}
