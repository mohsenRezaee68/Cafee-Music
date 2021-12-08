

using AventManagement.Application;
using AventManagement.Application.Contracts.Avent;
using AventManagement.Domain.AventAgg;
using AventManagement.Infrastructure.EFCore;
using AventManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AventManagement.Infrastructure.Configuration
{
    public class AventManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            
            
            services.AddTransient<IAventApplication, AventApplication>();
            services.AddTransient<IAventRepository, AventRepository>();

          //  services.AddTransient<IArticleQuery, ArticleQuery>();
           // services.AddTransient<IArticleCategoryQuery, ArticleCategoryQuery>();

            services.AddDbContext<AventContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
