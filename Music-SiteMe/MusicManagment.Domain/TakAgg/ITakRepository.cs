using _0_Framework.Domain;

using MusicManagement.Application.Contracts.Tak;
using MusicManagement.Domain.TakAgg;
using System.Collections.Generic;

namespace TakManagement.Domain.TakAgg
{
    public interface ITakRepository : IRepository<long, Tak>
    {
        EditTak GetDetails(long id);
        Tak GetWithCategory(long id);
        List<TakViewModel> Search(TakSearchModel searchModel);
    }
}
