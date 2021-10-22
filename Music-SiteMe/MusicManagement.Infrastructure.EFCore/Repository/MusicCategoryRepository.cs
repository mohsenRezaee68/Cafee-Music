

using _0_Framework.Application;
using _0_Framework.Infrastructure;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Domain.MusicCategoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace MusicManagement.Infrastructure.EFCore.Repository
{
    public class MusicCategoryRepository : RepositoryBase<long, MusicCategory>, IMusicCategoryRepository
    {
        private readonly MusicContext _context;

        public MusicCategoryRepository(MusicContext context) : base(context)
        {
            _context = context;
        }

       

        

        public EditMusicCategory GetDetails(long id)
        {
            return _context.MusicCategories.Select(x=> new EditMusicCategory() 
            { 
            Id = x.Id,
            Description = x.Description,
            Name=x.Name,
            Keywords = x.Keywords,
            MetaDescription=x.MetaDescription,
           // Picture="",
            PictureAlt=x.PictureAlt,
            PictureTitle=x.PictureTitle,
            Slug=x.Slug
            }).FirstOrDefault(x => x.Id==id);
        }

        public List<MusicCategoryViewModel> GetMusicCategories()
        {
            return _context.MusicCategories.Select(x => new MusicCategoryViewModel
            { 
            Id = x.Id,
            Name = x.Name
            
            }).ToList();
        }

        public string GetSlugById(long id)
        {
            return _context.MusicCategories.Select(x => new { x.Id, x.Slug }).FirstOrDefault(x => x.Id == id).Slug;
        }

       

        public List<MusicCategoryViewModel> Search(MusicCategorySearchModel searchModel)
        {
            var query = _context.MusicCategories.Select(x => new MusicCategoryViewModel
            {
                Id = x.Id,
                Picture = x.Picture,
                Name = x.Name,
                CreationDate = x.CreationDate.ToFarsi()
            });
            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
