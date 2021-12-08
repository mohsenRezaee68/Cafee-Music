using _0_Framework.Application;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Contact;
using CommentManagement.Domain.ContactAgg;
using CommnetManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace CommentManagement.Infrastructure.EFCore.Repository
{
    public class ContactRepository : RepositoryBase<long, Contact>, IContactRepository
    {
        private readonly CommentContext _context;

        public ContactRepository(CommentContext context) : base(context)
        {
            _context = context;
        }

        public List<ContactViewModel> GetContacts()
        {
            return _context.Cantacts.Select(x => new ContactViewModel
            {
                Id = x.Id,
                Etelaat = x.Etelaat,
                Matn = x.Matn,
                Email = x.Email,
                Phone = x.Phone,
                Instagram = x.Instagram,
                Telegram = x.Telegram,
                Watsap = x.Watsap
            }).ToList();
        }

        public EditContact GetDetails(long id)
        {
            return _context.Cantacts.Select(x => new EditContact
            {
                Id = x.Id,
               Etelaat = x.Etelaat,
               Matn = x.Matn,
               Email = x.Email,
               Phone = x.Phone ,
               Instagram = x.Instagram,
               Telegram = x.Telegram,
               Watsap = x.Watsap
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ContactViewModel> Search(ContactSearchModel searchModel)
        {
            var query = _context.Cantacts
                
                .Select(x => new ContactViewModel
                {
                    Id = x.Id,
                    Etelaat = x.Etelaat,
                    Matn = x.Matn,
                    Email = x.Email,
                    Phone = x.Phone,
                    Instagram = x.Instagram,
                    Telegram = x.Telegram,
                    Watsap = x.Watsap,
                    IsRemoved = x.IsRemoved,
                    CreationDate = x.CreationDate.ToFarsi()
                });

            if (searchModel.Id != 0)
                query = query.Where(x => x.Id == searchModel.Id);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
