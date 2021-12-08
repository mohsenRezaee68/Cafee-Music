

using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Contact;
using _01_LampshadeQuery.Query;
using CommentManagement.Application;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Application.Contracts.Contact;
using CommentManagement.Configuration.Permissions;
using CommentManagement.Domain.CommentAgg;
using CommentManagement.Domain.ContactAgg;
using CommentManagement.Infrastructure.EFCore.Repository;
using CommnetManagement.Infrastructure.EFCore;
using CommnetManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CommentManagement.Infrastructure.Configuration
{
    public class CommentManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<ICommentApplication, CommentApplication>();

            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IContactApplication, ContactApplication>();
            services.AddTransient<IContactQuery, ContactQuery>();
            services.AddTransient<IPermissionExposer, CommentPermissionExposer>();
            services.AddDbContext<CommentContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
