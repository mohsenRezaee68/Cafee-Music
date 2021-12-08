

using _0_Framework.Application;
using System.Collections.Generic;

namespace ArtistManagement.Application.Contracts.Logo
{
    public interface ILogoApplication
    {
        OperationResult Create(CreateLogo command);
        OperationResult Edit(EditLogo command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditLogo GetDetails(long id);
        List<LogoViewModel> GetList();
    }
}
