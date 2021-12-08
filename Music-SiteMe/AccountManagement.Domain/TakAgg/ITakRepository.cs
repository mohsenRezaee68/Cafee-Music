using _0_Framework.Domain;
using AccountManagement.Application.Contracts.Tak;
using System.Collections.Generic;

namespace AccountManagement.Domain.TakAgg
{
    public interface ITakRepository : IRepository<long, Tak>
    {
        EditTak GetDetails(long id);
        Tak GetWithMusicAndCategory(long id);
        List<TakViewModel> Search(TakSearchModel searchModel);
       
    }
}
