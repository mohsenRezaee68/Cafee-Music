using _0_Framework.Application;
using System.Collections.Generic;

namespace CommentManagement.Application.Contracts.Contact
{
    public interface IContactApplication
    {
        OperationResult Create(CreateContact command);
        OperationResult Edit(EditContact command);
        EditContact GetDetails(long id);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        List<ContactViewModel> GetMusic();
        List<ContactViewModel> Search(ContactSearchModel searchModel);
    }
}
