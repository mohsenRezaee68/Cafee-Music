using _0_Framework.Application;

using System.Collections.Generic;

namespace AccountManagement.Application.Contracts.Tak
{
    public interface ITakApplication
    {
        OperationResult Create(CreateTak command);
        OperationResult Edit(EditTak command);
        EditTak GetDetails(long id);
        OperationResult Confirm(long id);
        OperationResult Cancel(long id);
        List<TakViewModel> Search(TakSearchModel searchModel);
    }
}
