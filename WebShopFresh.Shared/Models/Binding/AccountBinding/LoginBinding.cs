using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.Binding.AccountBinding
{
    public class LoginBinding
    {
       
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
