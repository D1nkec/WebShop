using Microsoft.AspNetCore.Identity;
using WebShopFresh.Models.Dbo.AddressModels;


namespace WebShopFresh.Models.Dbo.UserModel
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public Address? Address { get; set; }
        public DateTime? RegistrationDate { get; set; }

    }
}
