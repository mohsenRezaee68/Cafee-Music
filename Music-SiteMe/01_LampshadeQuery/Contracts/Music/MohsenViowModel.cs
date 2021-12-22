using _01_LampshadeQuery.Contracts.Music;

using System.Collections.Generic;


namespace _01_LampshadeQuery.Contracts.Music
{
    public class MohsenViowModel
    {
    
         public List<MusicQueryModel> Alboms { get; set; }
        public int CurrentPage { get;  set; }
       
        public int PageCount { get;  set; }
    }

}

