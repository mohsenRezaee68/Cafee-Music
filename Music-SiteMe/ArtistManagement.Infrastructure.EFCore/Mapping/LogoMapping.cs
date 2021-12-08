

using ArtistManagement.Domain.LogoAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace LogoManagement.Infrastructure.EFCore.Mapping
{
    public class LogoMapping : IEntityTypeConfiguration<Logo>
    {
        public void Configure(EntityTypeBuilder<Logo> builder)
        {
            builder.ToTable("Logos");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Picture).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.NameSite).HasMaxLength(1000).IsRequired();
            
            
        }
    }
}
