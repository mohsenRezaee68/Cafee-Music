using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Music
{
    public class takViewforadmin
    {
        public List<TakViewForModel> Musics { get; set; }
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
