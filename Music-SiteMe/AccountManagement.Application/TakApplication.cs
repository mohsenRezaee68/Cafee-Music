
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Tak;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.TakAgg;
using System.Collections.Generic;


namespace TakManagement.Application
{
    public class TakApplication : ITakApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly ITakRepository _takRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthHelper _authHelper;
        public TakApplication(ITakRepository takRepository, IFileUploader fileUploader, IAccountRepository accountRepository,
            IAuthHelper authHelper)
        {
            _fileUploader = fileUploader;
            _takRepository = takRepository;
            _accountRepository = accountRepository;
            _authHelper = authHelper;
        }

        public OperationResult Cancel(long id)
        {
            var operation = new OperationResult();
            var comment = _takRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            comment.Cancel();
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Confirm(long id)
        {
            var operation = new OperationResult();
            var comment = _takRepository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            comment.Confirm();
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Create(CreateTak command)
        {
            long userId = _authHelper.CurrentAccountId();
            var bb = _accountRepository.Get(userId);
            command.UserId = userId;
            var operation = new OperationResult();
          //  var music = _takRepository.GetWithMusicAndCategory(command.AccountId);

            var path = $"{bb.Username}//{command.Name}";
            var musicPath = _fileUploader.Upload(command.Trak, path);

            var musicTrack = new Tak(musicPath,command.Name,command.Singer,command.PublishDate,command.Sabk , command.UserId,
                command.Slug,command.Keywords,command.MetaDescription);
            _takRepository.Create(musicTrack);
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditTak command)
        {
            var operation = new OperationResult();
            var productPicture = _takRepository.GetWithMusicAndCategory(command.Id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            

            productPicture.Edit( command.Name, command.Singer,  command.Sabk, 
                command.Slug, command.Keywords, command.MetaDescription);
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditTak GetDetails(long id)
        {
            return _takRepository.GetDetails(id);
        }

        public List<TakViewModel> Search(TakSearchModel searchModel)
        {
            return _takRepository.Search(searchModel);
        }
    }
}
