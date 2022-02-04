
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Identity;

[assembly: HostingStartup(typeof(Site.Api.IdentityHosting.IdentityHostingStartup))]
namespace Site.Api.IdentityHosting
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<UserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MainConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UserContext>()
                    .AddErrorDescriber<LocalizedIdentityErrorDescriber>();
                services.ConfigureApplicationCookie(options =>
                {
                    // Cookie settings
                    options.Cookie.HttpOnly = true;
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(10000);

                    options.LoginPath = "/Identity/Account/Login";
                    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                });
            });
        }
    }
}