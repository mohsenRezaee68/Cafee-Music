using AventManagement.Domain.AventAgg;
using AventManagement.Infrastructure.EFCore.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AventManagement.Infrastructure.EFCore
{
    public class AventContext : DbContext
    {
        public DbSet<Avent> Avents { get; set; }
       

        public AventContext(DbContextOptions<AventContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(AventMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
