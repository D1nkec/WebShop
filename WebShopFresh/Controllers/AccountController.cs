using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.AccountBinding;
using WebShopFresh.Shared.Models.Dto;
using WebShopFresh.Shared.Models.ViewModel.UserModel;



namespace WebShopFresh.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }



        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegistrationBinding model)
        {
            await _accountService.CreateUser(model, Roles.Buyer);
            return RedirectToAction("Products", "Home");
        }



        [Authorize]
        public async Task<IActionResult> MyProfile()
        {
            var profile = await _accountService.GetUserProfileAsync<ApplicationUserUpdateBinding>(User);
            return View(profile);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> MyProfile(ApplicationUserUpdateBinding model)
        {
            await _accountService.UpdateUserProfileAsync(model);
            return RedirectToAction("MyProfile");
        }

    }
}
