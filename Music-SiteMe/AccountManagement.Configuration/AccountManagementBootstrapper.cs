using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Account;
using _01_LampshadeQuery.Query;
using AccountManagement.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Application.Contracts.Tak;
using AccountManagement.Configuration.Permissions;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.RoleAgg;
using AccountManagement.Domain.TakAgg;
using AccountManagement.Infrastructure.EFCore.Repository;
using AccountMangement.Infrastructure.EFCore;
using AccountMangement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TakManagement.Application;

namespace AccountManagement.Configuration
{
    public class AccountManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IAccountApplication, AccountApplication>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountQuery, AccountQuery>();
            services.AddTransient<IRoleApplication, RoleApplication>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IPermissionExposer, AccountPermissionExposer>();
            services.AddTransient<ITakApplication, TakApplication>();
            services.AddTransient<ITakRepository, TakRepository>();
            services.AddDbContext<AccountContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
