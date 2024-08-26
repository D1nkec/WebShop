


namespace WebShopFresh.Services.Interface
{
    public interface IIdentitySetup
    {
        Task CreatePlatformAdminAsync();
        Task CreateRoleAsync(string role);
    }
}