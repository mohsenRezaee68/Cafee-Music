using _0_Framework.Domain;
using AventManagement.Application.Contracts.Avent;
using AventManagement.Domain.AventAgg;
using System.Collections.Generic;

namespace AventManagement.Domain.AventAgg
{
    public interface IAventRepository : IRepository<long, Avent>
    {
        EditAvent GetDetails(long id);
        
        List<AventViewModel> Search(AventSearchModel searchModel);
    }
}
