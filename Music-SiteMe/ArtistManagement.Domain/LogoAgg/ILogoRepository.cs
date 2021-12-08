

using _0_Framework.Domain;
using ArtistManagement.Application.Contracts.Logo;
using System.Collections.Generic;

namespace ArtistManagement.Domain.LogoAgg
{
    public interface ILogoRepository : IRepository<long, Logo>
    {
        EditLogo GetDetails(long id);
        List<LogoViewModel> GetList();
    }
}
