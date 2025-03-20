using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShopFresh.Data;
using WebShopFresh.Models.Dbo.UserModel;

namespace WebShopFresh.Services.Implementation
{
    public class SessionService
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        public SessionService(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }



        public async Task DeactivateAllExpiredSessions()
        {
            var expiredSessions = await _context.SessionItems.Where(y => y.Expires < DateTime.Now).ToListAsync();

            if(!expiredSessions.Any())
            {
                return;
            }
            foreach (var session in expiredSessions)
            {
                _context.SessionItems.Remove(session);
            }

            await _context.SaveChangesAsync();
        }
    }



    }
