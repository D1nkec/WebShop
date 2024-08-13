using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebShopFresh.Models.Dbo.UserModel
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public string Adress { get; set; }

        public DateTime? RegistrationDate { get; set; }
    }
}
