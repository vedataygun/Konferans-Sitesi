using Conference_Website.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference_Website.EmailService;
using Microsoft.Extensions.Options;
using System.Collections.Immutable;
using Microsoft.AspNetCore.Mvc;
using Conference_Website.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace Conference_Website
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {


            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase(databaseName: "InMemoryDatabase"),
                                                                                ServiceLifetime.Singleton,
                                                                                 ServiceLifetime.Singleton);



            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
            {
                x.LoginPath = "/notfound";
                x.LogoutPath = "/admin/Logout";
                x.Cookie.SameSite = SameSiteMode.Strict;
                x.Cookie.Name = ".Enwy.Security";
                x.Cookie.HttpOnly = true;

            });



            services.AddSingleton<HotmailEmailService>(em =>
            {
                var host = Configuration["EmailService:host"];
                var port = Convert.ToInt32(Configuration["EmailService:port"]);
                var enableSSL = Convert.ToBoolean(Configuration["EmailService:enableSSL"]);
                var username = Configuration["EmailService:username"];
                var password = Configuration["EmailService:password"];
                return new HotmailEmailService(host, port, enableSSL, username, password);
            });

            services.AddScoped<ValidateExtension>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"Anasayfa",
                    pattern:"anasayfa",
                    defaults: new {controller="Home",action="Index" }
                );
                endpoints.MapControllerRoute(
                   name: "Anasayfa",
                   pattern: "basvuru",
                   defaults: new { controller = "Participation", action = "Index" }
               );
                endpoints.MapControllerRoute(
                 name: "Anasayfa",
                 pattern: "email-dogrulama/{id}",
                 defaults: new { controller = "Participation", action = "Verification" }
                );
                endpoints.MapControllerRoute(
                  name: "Anasayfa",
                  pattern: "kayýt-basarili",
                  defaults: new { controller = "Participation", action = "VerificationSuccess" }
            );
                endpoints.MapControllerRoute(
                   name: "Anasayfa",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
               ) ;
            });
        }
    }
}
