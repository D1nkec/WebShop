using System.ComponentModel.DataAnnotations;




namespace WebShopFresh.Shared.Models.Binding.AccountBinding
{
    public class RegistrationBinding
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
