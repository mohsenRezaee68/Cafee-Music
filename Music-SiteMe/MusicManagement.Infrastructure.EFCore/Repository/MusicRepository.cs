
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Domain.MusicAgg;
using System.Collections.Generic;
using System.Linq;

namespace MusicManagement.Infrastructure.EFCore.Repository
{
    public class MusicRepository : RepositoryBase<long, Music>, IMusicRepository
    {
        private readonly MusicContext _context;

        public MusicRepository(MusicContext context) : base(context)
        {
            _context = context;
        }

        public EditMusic GetDetails(long id)
        {
            return _context.Musics.Select(x => new EditMusic
            {
                Id = x.Id,
                Name = x.Name,
                Dawnlod = x.Dawnlod,
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

        public List<MusicViewModel> GetMusics()
        {
            return _context.Musics.Select(x => new MusicViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Singer = x.Singer
            }).OrderByDescending(x => x.Id).ToList();
        }

        public Music GetMusicWithCategory(long id)
        {
            return _context.Musics
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id );
        }

        public List<MusicViewModel> Search(MusicSearchModel searchModel)
        {
            var query = _context.Musics
                .Include(x => x.Category)
                .Select(x => new MusicViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Dawnlod = x.Dawnlod,
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
                query = query.Where(x => x.Name.Contains(searchModel.Name));



            if (searchModel.MusicId != 0)
                query = query.Where(x => x.MusicId == searchModel.MusicId);



            if (searchModel.CategoryId != 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            query.OrderByDescending(x => x.Id).ToList();
            return query.ToList();
        }

       
    }
}
