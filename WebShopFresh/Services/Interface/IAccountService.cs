using System.Security.Claims;
using WebShopFresh.Shared.Models.Binding.AccountBinding;
using WebShopFresh.Shared.Models.ViewModel.AddressModels;
using WebShopFresh.Shared.Models.ViewModel.UserModel;



namespace WebShopFresh.Services.Interface
{
    public interface IAccountService
    {
        Task<ApplicationUserViewModel?> CreateUser(RegistrationBinding model, string role);
        Task<List<ApplicationUserViewModel>> GetRegisteredUsers(DateTime? notBefore = null);
        Task<ApplicationUserViewModel> GetUserProfileAsync(ClaimsPrincipal user);
        Task<T> GetUserProfileAsync<T>(ClaimsPrincipal user);
        Task<ApplicationUserViewModel> UpdateUserProfileAsync(ApplicationUserUpdateBinding model);
        Task<T> GetUserAddress<T>(ClaimsPrincipal user);
    }
}