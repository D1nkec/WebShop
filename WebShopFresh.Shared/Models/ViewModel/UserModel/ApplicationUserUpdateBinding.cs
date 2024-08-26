using System.ComponentModel.DataAnnotations;



namespace WebShopFresh.Shared.Models.ViewModel.UserModel
{
    public class ApplicationUserUpdateBinding
    {
        public string Id { get; set; }

        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string  Address { get; set; }
    }
}
