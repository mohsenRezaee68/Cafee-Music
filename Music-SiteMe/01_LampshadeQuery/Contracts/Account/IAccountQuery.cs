using _01_LampshadeQuery.Contracts.Music;
using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Account
{
    public interface IAccountQuery
    {
        AccountQueryModel GetAccount(long Id);
       List < UserMusicQueryModel> UserMusic();
        takUserViowModel UserMusicTak(int pageId = 1);
        List<UserMusicQueryModel> SearchTrack(string value);
       
        List<AccountAll> accountAlls();
        List<AccountAll> UsersActive();
        List<AccountAll> RemoveUsers();
    }
}
