using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MusicManagement.Domain.TakAgg;

namespace MusicManagement.Infrastructure.EFCore.Mapping
{
    public class TakMapping : IEntityTypeConfiguration<Tak>
    {
        public void Configure(EntityTypeBuilder<Tak> builder)
        {
            builder.ToTable("TakMusic");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Singer).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Melyat).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Sabk).HasMaxLength(255).IsRequired();
            
            builder.Property(x => x.Trak).HasMaxLength(10000);
            builder.Property(x => x.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);

            builder.Property(x => x.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Taks)
                .HasForeignKey(x => x.CategoryId);

         // builder.HasMany(x => x.MusicPictures)
         //     .WithOne(x => x.Product)
         //     .HasForeignKey(x => x.ProductId);
        }
    }
}
