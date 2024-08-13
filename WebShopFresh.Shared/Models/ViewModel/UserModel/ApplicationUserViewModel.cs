using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.ViewModel.UserModel
{
    public class ApplicationUserViewModel
    {
        public string Id { get; set; }


        [Display(Name = "Ime")]
        public string FirstName { get; set; }


        [Display(Name = "Prezime")]
        public string LastName { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string? Address { get; set; }
    }
}
