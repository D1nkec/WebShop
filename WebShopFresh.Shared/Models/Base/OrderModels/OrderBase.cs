using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.Base.OrderModels
{
    public class OrderBase
    {
        [Display(Name ="Poruka")]
        public string? Message { get; set; }
    }
}
