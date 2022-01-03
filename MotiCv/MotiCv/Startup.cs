using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MotiCv.Models.DbContexts;
using MotiCv.Models.Entities.Membership;

namespace MotiCv
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg=> {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                cfg.Filters.Add(new AuthorizeFilter(policy));
            });
            //brauzerde controller action adlari hamsi ya boyu hamsi ya kicik yazilmagi ucun 
            services.AddRouting(cfg => cfg.LowercaseUrls = true);

            services.AddDbContext<MotiCvDbContext>(cfg =>
            {
                // cstring appsetingsden gelen addir 
                cfg.UseSqlServer(Configuration.GetConnectionString("cstring"));
            })//membership mentiqinin klaslarinin taninmasi ucundur 
                .AddIdentity<MotiUser, MotiRole>().AddEntityFrameworkStores<MotiCvDbContext>();

            services.Configure<IdentityOptions>(cfg=> {
                cfg.Password.RequireDigit=false;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireUppercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequiredUniqueChars = 2;
                cfg.Password.RequiredLength = 3;

                cfg.User.RequireUniqueEmail = true;
                //cfg.User.AllowedUserNameCharacters 

                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0, 2, 0);
            });

            services.ConfigureApplicationCookie(cfg=> {
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accesdenied.html";
                cfg.ExpireTimeSpan = new TimeSpan(0, 3, 0);
                cfg.Cookie.Name = "Moti";
            });
            services.AddAuthentication();
            services.AddAuthorization(cfg=> {
                foreach (var policyname in Program.principals)
                {
                    cfg.AddPolicy(policyname, p => {
                        p.RequireAssertion(handler =>
                        {
                            return handler.User.HasClaim(policyname, "1");
                        });
                    });
                }
                
            });

            services.AddScoped<UserManager<MotiUser>>();
            services.AddScoped<SignInManager<MotiUser>>();
            services.AddScoped<RoleManager<MotiRole>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //errorlari cixartmag ucun (development dovrunde)
            app.UseDeveloperExceptionPage();
            //program ise dusdukde admin user yaratmaq ucun 
            app.SeedMembership();
            app.UseHttpsRedirection();
            //3w root papkasini cagirirb isletmek ucun 
            app.UseStaticFiles();
            //proyekt yonlendirmek ucun 
            app.UseRouting();
            //membership mentiqi ucun lazimdir 
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default-signin",
                    pattern:"signin.html",
                    defaults: new
                    {
                        area="",
                        controller="home",
                        action="signin"
                    });
                endpoints.MapControllerRoute(
                   name: "default-accesdenied",
                   pattern: "accesdenied.html",
                   defaults: new
                   {
                       area = "",
                       controller = "home",
                       action = "accesdenied"
                   });
                endpoints.MapControllerRoute(
                   name: "default-register",
                   pattern: "register.html",
                   defaults: new
                   {
                       area = "",
                       controller = "home",
                       action = "register"
                   });

                //admin hissesi ucun controller ve actionlari yoneltmek ucundur 
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=My}/{action=Index}/{id?}"
                );
                //user hisse ucun controller ve actionlari yonlendirir
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
