namespace _01_LampshadeQuery.Contracts.Music
{
    public class MusicTrackQueryModel
    {
        public long TrackId { get; set; }
        public string Track { get; set; }
        
        public string TrackName { get; set; }
        public bool IsRemoved { get; set; }
    }

}
