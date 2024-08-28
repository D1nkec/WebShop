using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.AccountBinding;
using WebShopFresh.Shared.Models.Dto;
using WebShopFresh.Shared.Models.ViewModel.UserModel;



namespace WebShopFresh.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(IAccountService accountService, SignInManager<ApplicationUser> signInManager)
        {
            _accountService = accountService;
            _signInManager = signInManager;
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginBinding model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Products", "Home");
                }
                else if (result.IsLockedOut)
                {
                    return RedirectToAction("Lockout", "Account");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }
            return View(model);
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
