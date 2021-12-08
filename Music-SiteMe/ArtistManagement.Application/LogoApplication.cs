
using _0_Framework.Application;
using ArtistManagement.Application.Contracts.Logo;

using ArtistManagement.Domain.LogoAgg;
using System.Collections.Generic;

namespace ArtistManagement.Application
{
    public class LogoApplication : ILogoApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly ILogoRepository _logoRepository;

        public LogoApplication(ILogoRepository logoRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _logoRepository = logoRepository;
        }

        public OperationResult Create(CreateLogo command)
        {
            var operation = new OperationResult();

            var pictureName = _fileUploader.Upload(command.Picture, "Logos");

            var Logos = new Logo(pictureName, command.NameSite);

            _logoRepository.Create(Logos);
            _logoRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditLogo command)
        {
            var operation = new OperationResult();
            var logo = _logoRepository.Get(command.Id);
            if (logo == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var pictureName = _fileUploader.Upload(command.Picture, "Logos");

            logo.Edit(pictureName, command.NameSite);
            _logoRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditLogo GetDetails(long id)
        {
            return _logoRepository.GetDetails(id);
        }

        public List<LogoViewModel> GetList()
        {
            return _logoRepository.GetList();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var slide = _logoRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            _logoRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _logoRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            _logoRepository.SaveChanges();
            return operation.Succedded();
        }
    }
}
