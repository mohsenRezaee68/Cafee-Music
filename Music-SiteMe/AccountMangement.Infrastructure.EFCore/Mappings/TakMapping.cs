using AccountManagement.Domain.TakAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace AccountManagement.Infrastructure.EFCore.Mapping
{
    public class TakMapping : IEntityTypeConfiguration<Tak>
    {
        public void Configure(EntityTypeBuilder<Tak> builder)
        {
            builder.ToTable("MusicTrackUser");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Track).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.TrackName).HasMaxLength(255).IsRequired();
            builder.Property(x => x.TrackSinger).HasMaxLength(255).IsRequired();
            builder.Property(x => x.TrackSinger).HasMaxLength(255);
            builder.Property(x => x.Sabk).HasMaxLength(255);
            builder.Property(x => x.Keywords).HasMaxLength(500);
            builder.Property(x => x.MetaDescription).HasMaxLength(500);
            builder.Property(x => x.Slug).HasMaxLength(500);

            builder.HasOne(x => x.account)
                .WithMany(x => x.Tracks)
                .HasForeignKey(x => x.UserId);
        }
    }
}
