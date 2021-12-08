

using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Slide;
using _01_LampshadeQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SlideManagement.Configuration.Permissions;
using SliderManagement.Application;
using SliderManagement.Application.Contracts.Slide;
using SliderManagement.Domain.SlideAgg;
using SliderManagement.Infrastructure.EFCore;
using SliderManagement.Infrastructure.EFCore.Repository;

namespace SliderManagement.Configuration
{
    public class SliderManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();
            services.AddTransient<ISlideQuery, SlideQuery>();
            services.AddTransient<IPermissionExposer, SlidePermissionExposer>();
            services.AddDbContext<SliderContext>(x => x.UseSqlServer(connectionString));
        }
    }
}