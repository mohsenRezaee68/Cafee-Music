using _0_Framework.Application;

using System.Collections.Generic;

namespace MusicManagement.Application.Contracts.Tak
{
    public interface ITakApplication
    {
        OperationResult Create(CreateTak command);
        OperationResult Edit(EditTak command);
        EditTak GetDetails(long id);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        List<TakViewModel> Search(TakSearchModel searchModel);
    }
}
