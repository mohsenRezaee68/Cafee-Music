using _0_Framework.Domain;
using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicCategoryAgg;

namespace MusicManagement.Domain.MusicTrackAgg
{
    public class MusicTrack : EntityBase
    {
        public long TrackId { get; private set; }
        public string Track { get; private set; }
        public string TrackName { get; private set; }
        public bool IsRemoved { get; private set; }
        public Music Music { get; private set; }
        public MusicCategory Category { get; private set; }

        public MusicTrack(long trackId, string track, string trackName)
        {
            TrackId = trackId;
            Track = track;
            TrackName = trackName;
        }

        public void Edit(long trackId, string track , string trackname)
        {
            TrackId = trackId;

            if (!string.IsNullOrWhiteSpace(track))
                Track = track;
            TrackName = trackname;
           // Name = name;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
