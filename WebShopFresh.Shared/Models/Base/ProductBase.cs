using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.Base
{
    public abstract class ProductBase
    {
        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Quantity { get; set; }

        public string? ImageUrl { get; set; }
    }
}
