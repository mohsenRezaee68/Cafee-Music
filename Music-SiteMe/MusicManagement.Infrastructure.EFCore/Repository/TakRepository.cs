
using _0_Framework.Application;
using _0_Framework.Infrastructure;

using Microsoft.EntityFrameworkCore;

using MusicManagement.Application.Contracts.Tak;

using MusicManagement.Domain.TakAgg;
using System.Collections.Generic;
using System.Linq;
using TakManagement.Domain.TakAgg;

namespace MusicManagement.Infrastructure.EFCore.Repository
{
    public class TakRepository : RepositoryBase<long, Tak>, ITakRepository
    {
        private readonly MusicContext _context;

        public TakRepository(MusicContext context) : base(context)
        {
            _context = context;
        }

        public EditTak GetDetails(long id)
        {
            return _context.Taks.Select(x => new EditTak
            {
                Id = x.Id,
                Name = x.Name,
                
                Singer=x.Singer,
                Melyat = x.Melyat,
                Sabk = x.Sabk,
                Ferestande = x.Ferestande,
                Slug = x.Slug,
                CategoryId = x.CategoryId,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<TakViewModel> GetTaks()
        {
            return _context.Taks.Select(x => new TakViewModel
            {
                Id = x.Id,
                NameMusic = x.Name,
                Singer = x.Singer,
                Trak = x.Trak,
                Sabk = x.Sabk,
                Melyat = x.Melyat

            }).ToList();
        }

      

        public Tak GetWithCategory(long id)
        {
            return _context.Taks
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<TakViewModel> Search(TakSearchModel searchModel)
        {
            var query = _context.Taks
                .Include(x => x.Category)
                .Select(x => new TakViewModel
                {
                    Id = x.Id,
                    NameMusic = x.Name,
                    Trak = x.Trak,
                    Singer = x.Singer,
                    Melyat = x.Melyat,
                    Sabk = x.Sabk,
                    Ferestande = x.Ferestande,
                    Category = x.Category.Name,
                    CategoryId = x.CategoryId,
                    MusicId = x.Id,
                    Picture = x.Picture,
                    IsRemoved = x.IsRemoved,
                    CreationDate = x.CreationDate.ToFarsi()
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.NameMusic.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Singer))
                query = query.Where(x => x.Singer.Contains(searchModel.Singer));
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
