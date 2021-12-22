

using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Domain.ArtistAgg;

using System.Collections.Generic;
using System.Linq;

namespace ArtistManagement.Infrastructure.EFCore.Repository
{
    public class ArtistRepository : RepositoryBase<long, Artist>,IArtistRepository
    {
        private readonly ArtistContext _context;

        public ArtistRepository(ArtistContext context) : base(context)
        {
            _context = context;
        }

        public EditArtist GetDetails(long id)
        {
            return _context.Artists.Select(x => new EditArtist
            {
                Id = x.Id,
                Name = x.Name,
                Laghab = x.Laghab,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Text = x.Text,
                ShertText = x.ShertText,
                Slug = x.Slug,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription
               
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArtistViewModel> GetList()
        {
            return _context.Artists.Select(x => new ArtistViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                Text = x.Text,
                IsRemoved = x.IsRemoved,
                ShertText=x.ShertText,
                Laghab=x.Laghab,
                Slug = x.Slug,
                Keywords = x.Keywords,
               
                CreationDate = x.CreationDate.ToFarsi()

            }).OrderByDescending(x => x.Id).ToList();
        }

        public List<ArtistViewModel> Search(ArtistSearchModel searchModel)
        {
            var query = _context.Artists.Select(x => new ArtistViewModel
            {
                Id = x.Id,
               Name = x.Name,
               Laghab = x.Laghab,
               Text = x.Text,
               ShertText = x.ShertText,
                Picture = x.Picture,
                
                IsRemoved = x.IsRemoved,
                
                
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
           
            if (!string.IsNullOrWhiteSpace(searchModel.Laghab))
                query = query.Where(x => x.Laghab.Contains(searchModel.Laghab));


            query.OrderByDescending(x => x.Id).ToList();
            return query.ToList();
        }
    }
}
