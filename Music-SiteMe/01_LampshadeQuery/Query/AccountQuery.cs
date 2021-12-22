using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Account;
using _01_LampshadeQuery.Contracts.Music;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.TakAgg;
using AccountMangement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class AccountQuery : IAccountQuery
    {
        private readonly AccountContext _accountContext;

        public AccountQuery(AccountContext accountContext)
        {
            _accountContext = accountContext;
        }

        public AccountQueryModel GetAccount(long Id)
        {
            var User = _accountContext.Accounts
               .Select(x => new AccountQueryModel
               {
                   Id = x.Id,
                   UserName = x.Username,
                   Name = x.Fullname,
                   Picture = x.ProfilePhoto,
                   Rol = x.Role.Name,
                   RolId = x.RoleId,
                 Email = x.Email,
                 Phone = x.Mobile,
                 Pass = x.Password,
                   Tracks = MapMusicTracks(x.Tracks),
               }).FirstOrDefault(x => x.Id == Id);

           
            return User;
        }

       

        private static List<UserMusicQueryModel> MapMusicTracks(List<Tak> Tracks)
        {
            return Tracks.Select(x => new UserMusicQueryModel
            {
                Id=x.Id,
               IsCanceled = x.IsCanceled,
               IsConfirmed = x.IsConfirmed,
                Track = x.Track,
                Name = x.TrackName,
                Singer = x.TrackSinger,
                Sabk=x.Sabk,
                PublishDate = x.CreationDate.ToString(),
               
            }).OrderByDescending(x => x.Id).ToList();
        }

       

        public List<UserMusicQueryModel> SearchTrack(string value)
        {
            var query = _accountContext.Taks
        .Include(x => x.account)
        .Where(x => x.IsCanceled == false)
        .Select(music => new UserMusicQueryModel
        {
            Id = music.Id,
           Sabk = music.Sabk,
           Name=music.TrackName,
           Singer = music.TrackSinger,
           UserName = music.account.Username,
           Track=music.Track,
           Photo = music.account.ProfilePhoto,
            PublishDate = music.PublishDate.ToFarsi(),
            Slug = music.Slug
        }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value)
                || x.Singer.Contains(value) || x.Sabk.Contains(value)||x.UserName.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<AccountAll> accountAlls()
        {
          
            return _accountContext.Accounts
              
               // .Where(x => x.IsRemoved == false)
              
                .Select(x => new AccountAll 
                {
                    Id = x.Id,
                    UserName = x.Fullname,
                  
                   
                }).OrderByDescending(x => x.Id).ToList();
        }
        public List<AccountAll> UsersActive()
        {
            
            return _accountContext.Accounts

                .Where(x => x.IsCanceled == false)

                .Select(x => new AccountAll
                {
                    Id = x.Id,
                    UserName = x.Fullname,


                }).OrderByDescending(x => x.Id).ToList();
        }
        public List<AccountAll> RemoveUsers()
        {

            return _accountContext.Accounts

                .Where(x => x.IsCanceled == true)

                .Select(x => new AccountAll
                {
                    Id = x.Id,
                    UserName = x.Fullname,


                }).OrderByDescending(x => x.Id).ToList();
        }

      

        public List<UserMusicQueryModel> UserMusic()
        {
            var Music = _accountContext.Taks
                .Include(x => x.account)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)

              .Select(x => new UserMusicQueryModel
              {
                  Id = x.Id,
                  Name = x.TrackName,
                  Singer = x.TrackSinger,
                  Sabk = x.Sabk,
                  Slug = x.Slug,
                  Track = x.Track,
                  PublishDate = x.PublishDate.ToFarsi(),
                  UserName = x.account.Username,
                  Photo = x.account.ProfilePhoto,
              }).OrderByDescending(x => x.Id).ToList();


            return Music;
        }

        public takUserViowModel UserMusicTak(int pageId = 1)
        {
            var Music = _accountContext.Taks
               .Include(x => x.account)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
             .Select(x => new UserMusicQueryModel
             {
                 Id = x.Id,
                 Name = x.TrackName,
                 Singer = x.TrackSinger,
                 Sabk = x.Sabk,
                 Slug = x.Slug,
                 Track = x.Track,
                 PublishDate = x.PublishDate.ToFarsi(),
                 UserName = x.account.Username,
                 Photo = x.account.ProfilePhoto,
             }).OrderByDescending(x => x.Id).ToList();


            int take = 20;
            int skip = (pageId - 1) * take;

            takUserViowModel list = new takUserViowModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(Music.Count() / (double)take);

            list.Musics = Music.Skip(skip).Take(take).ToList();
            return list;
        }
    }
    
}
