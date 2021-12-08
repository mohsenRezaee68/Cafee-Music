using _01_LampshadeQuery.Contracts.Contact;

using CommnetManagement.Infrastructure.EFCore;

using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class ContactQuery : IContactQuery
    {
        private readonly CommentContext _Context;

        public ContactQuery(CommentContext commentContext)
        {
            _Context = commentContext;
        }

        public ContactQueryModel GetContacts()
        {
            var contact = _Context.Cantacts
              .Select(x => new ContactQueryModel
               {
                   Id = x.Id,
                   Etelaat=x.Etelaat,
                   Matn=x.Matn,
                   Phone=x.Phone,
                   Email=x.Email,
                   Telegram=x.Telegram,
                   Instagram=x.Instagram,
                   Watsap=x.Watsap
                  }).FirstOrDefault();

           
            return contact;
        }
    }
}
