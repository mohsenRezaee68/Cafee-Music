

using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Artist;

using _01_LampshadeQuery.Query;
using ArtistManagement.Application;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Application.Contracts.Logo;
using ArtistManagement.Configuration.Permissions;
using ArtistManagement.Domain.ArtistAgg;
using ArtistManagement.Domain.LogoAgg;
using ArtistManagement.Infrastructure.EFCore;
using ArtistManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace ArtistManagement.Configuration
{
    public class ArtistManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArtistApplication, ArtistApplication>();
            services.AddTransient<IArtistRepository, ArtistRepository>();

            services.AddTransient<ILogoApplication, LogoApplication>();
            services.AddTransient<ILogoRepository, Logoepository>();
           
            services.AddTransient<IArtistQuery, ArtistQuery>();
           
            services.AddTransient<IPermissionExposer, ArtistPermissionExposer>();

            services.AddDbContext<ArtistContext>(x => x.UseSqlServer(connectionString));
        }
    }
}