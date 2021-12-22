using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Music;

using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Artist
{
    public class ArtistsViowMode
    {
    
         public List<ArtistQueryModel> Artists { get; set; }
        public int CurrentPage { get;  set; }
       
        public int PageCount { get;  set; }
    }

}

