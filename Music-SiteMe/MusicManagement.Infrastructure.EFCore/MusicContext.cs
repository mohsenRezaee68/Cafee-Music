
using Microsoft.EntityFrameworkCore;

using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicCategoryAgg;
using MusicManagement.Domain.MusicTrackAgg;
using MusicManagement.Domain.TakAgg;
using MusicManagement.Infrastructure.EFCore.Mapping;

namespace MusicManagement.Infrastructure.EFCore
{
    public class MusicContext : DbContext
    {
        public DbSet<Tak> Taks { get; set; }
        public DbSet<Music> Musics { get; set; }
        public DbSet<MusicCategory> MusicCategories { get; set; }
        public DbSet<MusicTrack> MusicTracks { get; set; }
       
        //  public DbSet<Slide> Slides { get; set; }

        // public DbSet<Order> Orders { get; set; }

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(MusicCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
