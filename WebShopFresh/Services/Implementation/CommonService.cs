using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Json;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.SessionModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Dto;

namespace WebShopFresh.Services.Implementation
{
    public class CommonService : ICommonService
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        private AppSettings _appSettings;

        public CommonService(UserManager<ApplicationUser> userManager, ApplicationDbContext context, IOptions<AppSettings> appSettings)
        {
            _userManager = userManager;
            _context = context;
            _appSettings = appSettings.Value;
        }

        public async Task DeactivateAllExpiredSessions()
        {
            var expiredSessions = await _context.SessionItems.Where(y => y.Expires < DateTime.Now).ToListAsync();

            if (!expiredSessions.Any())
            {
                return;
            }
            foreach (var session in expiredSessions)
            {
                _context.SessionItems.Remove(session);
            }
            await _context.SaveChangesAsync();
        }


        public async Task RemoveFromSession(string key, ClaimsPrincipal user)
        {
            var appUser = await _userManager.GetUserAsync(user);
            var dbo = await _context.SessionItems.Include(y => y.User).FirstOrDefaultAsync(y => y.Key == key && y.UserId == appUser.Id
                && y.Expires > DateTime.Now.AddHours(_appSettings.ExpireSessionInHours * -1));
            if (dbo != null)
            {
                _context.SessionItems.Remove(dbo);
                await _context.SaveChangesAsync();
            }
        }


        public async Task AddSessionItem(string key, object value, ClaimsPrincipal user)
        {
            var appUser = await _userManager.GetUserAsync(user);
            await RemoveFromSession(key, user);

            var dbo = new SessionItem
            {
                Key = key,
                Value = JsonSerializer.Serialize(value),
                UserId = appUser.Id,
                Expires = DateTime.Now.AddHours(_appSettings.ExpireSessionInHours)
            };

            _context.SessionItems.Add(dbo);
            await _context.SaveChangesAsync();
        }


        public async Task<T> GetSessionItem<T>(string key, ClaimsPrincipal user)
        {
            var appUser = await _userManager.GetUserAsync(user);
            var dbo = await _context.SessionItems
                .Include(y => y.User)
                .FirstOrDefaultAsync(y => y.Key == key
                && y.UserId == appUser.Id
                && y.Expires > DateTime.Now);

            if (dbo == null)
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(dbo.Value);
        }
    }








}
