using _01_LampshadeQuery.Contracts.Account;
using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Account
{
    public class takUserViowModel
    {
        public List<UserMusicQueryModel> Musics { get; set; }
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }
    }
}
