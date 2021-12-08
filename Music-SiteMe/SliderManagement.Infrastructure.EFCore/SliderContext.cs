

using Microsoft.EntityFrameworkCore;
using SliderManagement.Domain.SlideAgg;
using SliderManagement.Infrastructure.EFCore.Mapping;

namespace SliderManagement.Infrastructure.EFCore
{
    public class SliderContext : DbContext
    {

        public DbSet<Slide> Slides { get; set; }
       

        public SliderContext(DbContextOptions<SliderContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(SlideMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}