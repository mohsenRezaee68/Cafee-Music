

using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Music;
using _01_LampshadeQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicManagement.Application;

using MusicManagement.Application.Contracts.Music;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Application.Contracts.Tak;
using MusicManagement.Configuration.Permissions;
using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicCategoryAgg;
using MusicManagement.Domain.MusicTrackAgg;
using MusicManagement.Infrastructure.EFCore;
using MusicManagement.Infrastructure.EFCore.Repository;
using TakManagement.Application;
using TakManagement.Domain.TakAgg;

namespace MusicManagement.Configuration
{
   public class MusicManagementBootstrapper
    {
        public static void configure(IServiceCollection services,string connectionString) 
        {
            services.AddTransient<IMusicCategoryApplication, MusicCategoryApplication>();
            services.AddTransient<IMusicCategoryRepository, MusicCategoryRepository>();

            services.AddTransient<IMusicApplication, MusicApplication>();
            services.AddTransient<IMusicRepository, MusicRepository>();

            services.AddTransient<IMusicTrackApplication, MusicTrackApplication>();
            services.AddTransient<IMusicTrackRepository, MusicTrackRepository>();

            services.AddTransient<ITakApplication, TakApplication>();
            services.AddTransient<ITakRepository, TakRepository>();

            services.AddTransient<IMusicQuery, MusicQuery>();
            services.AddTransient<IPermissionExposer, MusicPermissionExposer>();
            services.AddDbContext<MusicContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
