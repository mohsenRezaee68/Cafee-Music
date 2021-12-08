using _0_Framework.Application;
using System.Collections.Generic;

namespace AventManagement.Application.Contracts.Avent
{
    public interface IAventApplication
    {
        OperationResult Create(CreateAvent command);
        OperationResult Edit(EditAvent command);
        EditAvent GetDetails(long id);
        List<AventViewModel> Search(AventSearchModel searchModel);
    }
}
