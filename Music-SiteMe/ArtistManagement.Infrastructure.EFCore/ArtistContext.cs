

using ArtistManagement.Domain.ArtistAgg;
using ArtistManagement.Domain.LogoAgg;
using ArtistManagement.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ArtistManagement.Infrastructure.EFCore
{
    public class ArtistContext : DbContext
    {

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Logo> Logos { get; set; }

        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArtistMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}