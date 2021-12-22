namespace musicManagement.Application.Contracts.MusicTrack
{
    public class MusicTrackViewModel
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public string Music { get; set; }
        public string Track { get; set; }
        public string TrackName { get; set; }
        public string Singer {  get; set; }
        public string Name {  get; set; }
        public string CreationDate { get; set; }
        public long TrackId { get; set; }
        public bool IsRemoved { get; set; }
        public string frestande { get; set; }
    }
}
