using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Binding.AccountBinding;
using WebShopFresh.Shared.Models.ViewModel.UserModel;

namespace WebShopFresh.Services.Implementation
{
    public class AccountService : IAccountService
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
        }



        /// <summary>
        /// UPDATE USER PROFILE
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<ApplicationUserViewModel> UpdateUserProfileAsync(ApplicationUserUpdateBinding model)
        {
            var dbo = await _context.Users
                .Include(y => y.Address) // Include address to update it properly
                .FirstOrDefaultAsync(y => y.Id == model.Id);

            if (dbo == null)
            {
                throw new Exception("User not found");
            }

            // Map basic user information
            dbo.FirstName = model.FirstName;
            dbo.LastName = model.LastName;
            

            // Check if the address already exists
            if (dbo.Address != null)
            {
                // Update address properties
                dbo.Address.Country = model.Address.Country;
                dbo.Address.City = model.Address.City;
                dbo.Address.Street = model.Address.Street;
                dbo.Address.Number = model.Address.Number;
            }
            else if (model.Address != null) // Handle new address creation
            {
                dbo.Address = new Address
                {
                    Country = model.Address.Country,
                    City = model.Address.City,
                    Street = model.Address.Street,
                    Number = model.Address.Number
                };
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<ApplicationUserViewModel>(dbo);
        }



        /// <summary>
        /// GET CURRENT USER PROFILE
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUserViewModel> GetUserProfileAsync(ClaimsPrincipal user)
        {

            var dbo = await _context.Users
                 .Include(y => y.Address)
                .FirstOrDefaultAsync(y => y.Id == _userManager.GetUserId(user));
            return _mapper.Map<ApplicationUserViewModel>(dbo);
        }



        /// <summary>
        /// Get User Profile Async with dif. response view model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<T> GetUserProfileAsync<T>(ClaimsPrincipal user)
        {
            var dbo = await _context.Users
                 .Include(y => y.Address)
                .FirstOrDefaultAsync(y => y.Id == _userManager.GetUserId(user));
            return _mapper.Map<T>(dbo);
        }




        public async Task<ApplicationUserViewModel?> CreateUser(RegistrationBinding model, string role)
        {
            var find = await _userManager.FindByEmailAsync(model.Email);
            if (find != null)
            {
                return null;
            }

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                RegistrationDate = DateTime.Now
            };

            user.EmailConfirmed = true;
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);
                await _userManager.UpdateAsync(user);
                await _signInManager.SignInAsync(user, isPersistent: false);
                return _mapper.Map<ApplicationUserViewModel>(user);
            }

            return null;

        }

     public async Task<T> GetUserAddress<T>(ClaimsPrincipal user)
        {
            var appUser = await _userManager.GetUserAsync(user);
            var dboUser = _context.Users.Include(y => y.Address).FirstOrDefault(x => x.Id == appUser.Id);
            return _mapper.Map<T>(dboUser.Address);
        }


        public async Task<List<ApplicationUserViewModel>> GetRegisteredUsers(DateTime? notBefore = null)
        {
            if (notBefore.HasValue)
            {
                notBefore = DateTime.Now.AddDays(-1);
            }
            var newUsers = await _context.Users.Where(y => y.RegistrationDate > notBefore).ToListAsync();
            return newUsers.Select(y => _mapper.Map<ApplicationUserViewModel>(y)).ToList();
        }

    }
}
