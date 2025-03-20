using System.ComponentModel.DataAnnotations;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Shared.Interfaces;
using WebShopFresh.Shared.Models.Base.Session;

namespace WebShopFresh.Models.Dbo.SessionModels
{
    public class SessionItem : SessionItemBase, IBaseTableAtributes
    {
        [Key]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Valid { get; set; }
        public ApplicationUser? User { get; set; }
        public string? UserId { get; set; }
    }
}
