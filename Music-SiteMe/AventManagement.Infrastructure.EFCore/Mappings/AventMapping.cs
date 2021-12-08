using AventManagement.Domain.AventAgg;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AventManagement.Infrastructure.EFCore.Mappings
{
    public class AventMapping : IEntityTypeConfiguration<Avent>
    {
        public void Configure(EntityTypeBuilder<Avent> builder)
        {
            builder.ToTable("Avents");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(500);
            builder.Property(x => x.Toppic).HasMaxLength(1000);
            builder.Property(x => x.Picture).HasMaxLength(500);
            builder.Property(x => x.PictureAlt).HasMaxLength(500);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(600);
            builder.Property(x => x.Keywords).HasMaxLength(100);
            builder.Property(x => x.MetaDescription).HasMaxLength(150);
           

            
        }
    }
}
