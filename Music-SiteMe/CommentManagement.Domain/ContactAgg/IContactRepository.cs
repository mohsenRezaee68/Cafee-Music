

using _0_Framework.Domain;
using CommentManagement.Application.Contracts.Contact;
using System.Collections.Generic;

namespace CommentManagement.Domain.ContactAgg
{
    public interface IContactRepository : IRepository<long, Contact>
    {
        EditContact GetDetails(long id);
        
        List<ContactViewModel> GetContacts();
        List<ContactViewModel> Search(ContactSearchModel searchModel);
    }
}
