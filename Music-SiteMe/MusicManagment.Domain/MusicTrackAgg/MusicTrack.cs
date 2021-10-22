

using _0_Framework.Domain;
using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicCategoryAgg;
using System.Collections.Generic;

namespace MusicManagement.Domain.MusicTrackAgg
{
    public class MusicTrack : EntityBase
    {
        public long TrackId { get; private set; }
        public string Track { get; private set; }
        public bool IsRemoved { get; private set; }
        public Music Music { get; private set; }
        public MusicCategory Category { get; private set; }
        public MusicTrack( string track, long trackId)
        {
            TrackId = trackId;
            Track = track;
          
           
            IsRemoved = false;
        }

        public void Edit( string track , long trackId)
        {
            TrackId = trackId;

            if (!string.IsNullOrWhiteSpace(track))
                Track = track;
            
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
