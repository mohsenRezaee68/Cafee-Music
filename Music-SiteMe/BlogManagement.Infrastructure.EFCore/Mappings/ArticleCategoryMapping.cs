using BlogManagement.Domain.ArticleCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogManagement.Infrastructure.EFCore.Mappings
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.Picture).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(600);
            builder.Property(x => x.Keywords).HasMaxLength(800);
                builder.HasMany(x => x.Articles)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
