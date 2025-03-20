using System.Security.Claims;

namespace WebShopFresh.Services.Interface
{
    public interface ICommonService
    {
        Task AddSessionItem(string key, object value, ClaimsPrincipal user);
        Task DeactivateAllExpiredSessions();
        Task<T> GetSessionItem<T>(string key, ClaimsPrincipal user);
        Task RemoveFromSession(string key, ClaimsPrincipal user);
    }
}