using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicManagement.Domain.MusicAgg;

namespace MusicManagement.Infrastructure.EFCore.Mapping
{
    public class MusicMapping : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.ToTable("Musics");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Singer).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Melyat).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Sabk).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Ferestande).HasMaxLength(255).IsRequired();
            
            builder.Property(x => x.ShortDescription).HasMaxLength(500).IsRequired();
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);

            builder.Property(x => x.Keywords).HasMaxLength(100).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Musics)
                .HasForeignKey(x => x.CategoryId);

         // builder.HasMany(x => x.MusicPictures)
         //     .WithOne(x => x.Product)
         //     .HasForeignKey(x => x.ProductId);
        }
    }
}
