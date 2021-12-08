

using _0_Framework.Application;
using CommentManagement.Application.Contracts.Contact;
using CommentManagement.Domain.ContactAgg;
using System.Collections.Generic;

namespace CommentManagement.Application
{
    public class ContactApplication : IContactApplication
    {
        
        private readonly IContactRepository _contactRepository;
      

        public ContactApplication(IContactRepository contactRepository)
        {
            
            _contactRepository = contactRepository;
           
        }

        public OperationResult Create(CreateContact command)
        {
            var operation = new OperationResult();
            if (_contactRepository.Exists(x => x.Matn == command.Matn ))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            var product = new Contact(command.Etelaat, command.Matn, command.Phone, command.Email, command.Instagram,
                command.Telegram, command.Watsap);
            _contactRepository.Create(product);
            _contactRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditContact command)
        {
            var operation = new OperationResult();
            var product = _contactRepository.Get(command.Id);

            if (_contactRepository.Exists(x =>  x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

             product.Edite(command.Etelaat, command.Matn, command.Phone, command.Email, command.Instagram,
                  command.Telegram, command.Watsap);

            _contactRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditContact GetDetails(long id)
        {
            return _contactRepository.GetDetails(id);
        }

        public List<ContactViewModel> GetMusic()
        {
            return _contactRepository.GetContacts();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var music = _contactRepository.Get(id);
            if (music == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            music.Remove();
            _contactRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var music = _contactRepository.Get(id);
            if (music == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            music.Restore();
            _contactRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<ContactViewModel> Search(ContactSearchModel searchModel)
        {
            return _contactRepository.Search(searchModel);
        }
    }
}
