using Microsoft.AspNetCore.Identity;
using WebShopFresh.Models.Dbo.AddressModels;
using WebShopFresh.Models.Dbo.UserModel;
using WebShopFresh.Services.Interface;
using WebShopFresh.Shared.Models.Dto;



namespace WebShopFresh.Services.Implementation
{
    public class IdentitySetup : IIdentitySetup
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;

        public IdentitySetup(IServiceScopeFactory scopeFactory)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                CreateRoleAsync(Roles.Admin).Wait();
                CreateRoleAsync(Roles.Buyer).Wait();
                CreatePlatformAdminAsync().Wait();
            }
        }



        public async Task CreatePlatformAdminAsync()
        {
            string adminEmail = "webshopadmin@gmail.com";

            var find = await userManager.FindByEmailAsync(adminEmail);
            if (find != null)
            {
                return;
            }

            var user = new ApplicationUser
            {
                Email = adminEmail,
                UserName = adminEmail,
                FirstName = "Admin",
                LastName = "Admin",
                EmailConfirmed = true,
                // Ensure AddressId is not set for the admin user
            };

            string pwd = "1Admin0!";
            var createUser = await userManager.CreateAsync(user, pwd);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(user, Roles.Admin);
            }
        }




        public async Task CreateRoleAsync(string role)
        {

            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole
                {
                    Name = role,
                });
            }
        }

    }
}
