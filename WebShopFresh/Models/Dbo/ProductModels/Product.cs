using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using WebShopFresh.Models.Dbo.CategoryModels;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.ProductModels;

namespace WebShopFresh.Models.Dbo.ProductModels
{
    public class Product : ProductBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }

        public Category? Category { get; set; }
        public long? CategoryId { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }

        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
