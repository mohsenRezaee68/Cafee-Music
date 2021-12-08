using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Account
{
    public interface IAccountQuery
    {
        AccountQueryModel GetAccount(long Id);
       List<UserMusicQueryModel> UserMusic();
        List<UserMusicQueryModel> SearchTrack(string value);
       
        List<AccountAll> accountAlls();
        List<AccountAll> UsersActive();
        List<AccountAll> RemoveUsers();
    }
}
