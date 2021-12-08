
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AventManagement.Application.Contracts.Avent;
using AventManagement.Domain.AventAgg;

using System.Collections.Generic;
using System.Linq;

namespace AventManagement.Infrastructure.EFCore.Repository
{
    public class AventRepository : RepositoryBase<long, Avent>, IAventRepository
    {
        private readonly AventContext _context;

        public AventRepository(AventContext context) : base(context)
        {
            _context = context;
        }

        public EditAvent GetDetails(long id)
        {
            return _context.Avents.Select(x => new EditAvent
            {
                Id = x.Id,
                Toppic = x.Toppic,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                PublishDate = x.PublishDate.ToFarsi(),
                Slug = x.Slug,
                Title = x.Title
            }).FirstOrDefault(x => x.Id == id);
        }

        

        public List<AventViewModel> Search(AventSearchModel searchModel)
        {
            var query = _context.Avents.Select(x => new AventViewModel
            {
                Id = x.Id,
                Toppic = x.Toppic,
                Picture = x.Picture,
                PublishDate = x.PublishDate.ToFarsi(),
                
                Title = x.Title
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Toppic))
                query = query.Where(x => x.Toppic.Contains(searchModel.Toppic));

          

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
