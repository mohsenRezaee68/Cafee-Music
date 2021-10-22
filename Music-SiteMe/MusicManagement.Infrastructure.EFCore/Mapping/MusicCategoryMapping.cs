using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicManagement.Domain.MusicCategoryAgg;

namespace MusicManagement.Infrastructure.EFCore.Mapping
{
    public class MusicCategoryMapping : IEntityTypeConfiguration<MusicCategory>
    {
        public void Configure(EntityTypeBuilder<MusicCategory> builder)
        {
            builder.ToTable("MusicCategories");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);
            builder.Property(x => x.Keywords).HasMaxLength(80).IsRequired();
            builder.Property(x => x.MetaDescription).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsRequired();

           builder.HasMany(x => x.Musics)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
