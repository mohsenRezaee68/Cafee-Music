using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Configuration;
using ArtistManagement.Configuration;
using BlogManagement.Infrastructure.Configuration;
using CommentManagement.Infrastructure.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicManagement.Configuration;
using ServiceHost;
using SliderManagement.Configuration;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace ServerHost
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
            services.AddRazorPages();
            services.AddHttpContextAccessor();
            var connectionString = Configuration.GetConnectionString("Music-MeDb");
            MusicManagementBootstrapper.configure(services, connectionString);
            SliderManagementBootstrapper.Configure(services, connectionString);
            BlogManagementBootstrapper.Configure(services, connectionString);
            CommentManagementBootstrapper.Configure(services, connectionString);
            AccountManagementBootstrapper.Configure(services, connectionString);
            ArtistManagementBootstrapper.Configure(services, connectionString);

            services.AddRazorPages();
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
            services.AddSingleton<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IFileUploader, FileUploader>();
            services.AddTransient<IAuthHelper, AuthHelper>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.Lax;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
                {
                    o.LoginPath = new PathString("/AccountLogin");
                    o.LogoutPath = new PathString("/AccountLogup");
                    o.AccessDeniedPath = new PathString("/AccessDenied");
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminArea",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator, Roles.ContentUploader }));

                options.AddPolicy("Accounts",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));

                options.AddPolicy("Artists",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));

                options.AddPolicy("Blog",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));
                options.AddPolicy("Comments",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));
                options.AddPolicy("Contact",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));
                options.AddPolicy("Musics",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator}));
                options.AddPolicy("Sliders",
                    builder => builder.RequireRole(new List<string> { Roles.Administrator }));
               
            });
            
            services.AddRazorPages()
               .AddMvcOptions(options => options.Filters.Add<SecurityPageFilter>())
               .AddRazorPagesOptions(options =>
               {
                   options.Conventions.AuthorizeAreaFolder("Administration", "/","AdminArea");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Accounts", "Account");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Artists", "Artist");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Comments", "Comment");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Contact", "Contact");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Musics", "Music");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Sliders", "Slider");
                   options.Conventions.AuthorizeAreaFolder("Administration", "/Blog", "Blog");
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
           
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
