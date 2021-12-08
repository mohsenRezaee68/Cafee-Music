

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicManagement.Domain.MusicTrackAgg;

namespace MusicManagement.Infrastructure.EFCore.Mapping
{
    public class MusicTrackMapping : IEntityTypeConfiguration<MusicTrack>
    {
        public void Configure(EntityTypeBuilder<MusicTrack> builder)
        {
            builder.ToTable("MusicTrack");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Track).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.TrackName).HasMaxLength(255).IsRequired();

            builder.HasOne(x => x.Music)
                .WithMany(x => x.MusicTracks)
                .HasForeignKey(x => x.TrackId);
        }
    }
}
