using System.ComponentModel.DataAnnotations;
using WebShopFresh.Shared.Models.Binding.AddressModels;



namespace WebShopFresh.Shared.Models.ViewModel.UserModel
{
    public class ApplicationUserUpdateBinding
    {
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public AddressUpdateBinding? Address { get; set; }
    }
}
