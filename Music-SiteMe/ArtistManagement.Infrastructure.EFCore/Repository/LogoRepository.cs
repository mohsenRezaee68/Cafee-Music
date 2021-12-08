
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using ArtistManagement.Application.Contracts.Logo;
using ArtistManagement.Domain.LogoAgg;

using System.Collections.Generic;
using System.Linq;

namespace ArtistManagement.Infrastructure.EFCore.Repository
{
    public class Logoepository : RepositoryBase<long, Logo>, ILogoRepository
    {
        private readonly ArtistContext _context;

        public Logoepository(ArtistContext context) : base(context)
        {
            _context = context;
        }

        public EditLogo GetDetails(long id)
        {
            return _context.Logos.Select(x => new EditLogo
            {
                Id = x.Id,
                NameSite = x.NameSite,
               
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<LogoViewModel> GetList()
        {
            return _context.Logos.Select(x => new LogoViewModel
            {
                Id = x.Id,
                NameSite = x.NameSite,
                Picture = x.Picture,
               
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
