

using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Tak;
using AccountManagement.Domain.TakAgg;
using AccountMangement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;


namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class TakRepository : RepositoryBase<long, Tak>, ITakRepository
    {
        private readonly AccountContext _context;

        public TakRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public EditTak GetDetails(long id)
        {
            return _context.Taks
               .Include(x => x.account)
          .Select(x => new EditTak
          {
              Id = x.Id,
              UserId = x.account.Id,
              Name = x.TrackName,
              Singer = x.TrackSinger,
              Keywords = x.Keywords,
              MetaDescription = x.MetaDescription,
              Slug = x.Slug,
          }).FirstOrDefault(x => x.Id == id);
        }

        public Tak GetWithMusicAndCategory(long id)
        {
            return _context.Taks
                  .Include(x => x.account)
                 .FirstOrDefault(x => x.Id == id);
        }

        public List<TakViewModel> GetTaks()
        {
            return _context.Taks.Select(x => new TakViewModel
            {
                Id = x.Id,
                NameMusic = x.TrackName,
                Singer = x.TrackSinger,
                Trak = x.Track,
                Sabk = x.Sabk,
               

            }).ToList();
        }

        public List<TakViewModel> Search(TakSearchModel searchModel)
        {
            var query = _context.Taks
               .Include(x => x.account)
               .Where(x => x.account.Id == x.UserId)
               .Include(x => x.role)   

               .Select(x => new TakViewModel
               {
                   Id = x.Id,
                   NameMusic = x.TrackName,
                   CreationDate = x.CreationDate.ToString(),
                   Trak = x.Track,
                   UserId = x.account.Id,
                   IsCanceled = x.IsCanceled,
                   IsConfirmed = x.IsConfirmed,
                   Singer = x.TrackSinger,
                   UserAccount = x.account.Username,
                   UserName = x. account.Fullname,
                   Sabk = x.Sabk,
                   Rol = x.role.Name,
               });

           

            if (!string.IsNullOrWhiteSpace(searchModel.UserAccount))
                query = query.Where(x => x.UserAccount.Contains(searchModel.UserAccount));

            if (!string.IsNullOrWhiteSpace(searchModel.AccountName))
                query = query.Where(x => x.UserName.Contains(searchModel.AccountName));
          
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
