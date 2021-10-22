namespace MusicManagement.Application.Contracts.MusicTrack
{
    public class MusicTrackSearchModel
    {
        public long Id { get; set; }
        public long TrackId { get; set; }
        public string Singer {  get; set; }
        public string Name {  get; set; }
        public long CategoryId { get; set; }
    }
}
