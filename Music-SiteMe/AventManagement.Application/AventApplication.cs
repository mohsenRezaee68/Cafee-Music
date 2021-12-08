using _0_Framework.Application;
using AventManagement.Application.Contracts.Avent;
using AventManagement.Domain.AventAgg;
using AventManagement.Infrastructure.EFCore.Repository;
using System.Collections.Generic;

namespace AventManagement.Application
{
    public class AventApplication : IAventApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly AventRepository _aventRepository;
     
        public AventApplication(IAventRepository aventRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _aventRepository = (AventRepository)aventRepository;
            
        }

        public OperationResult Create(CreateAvent command)
        {
            var operation = new OperationResult();
            if (_aventRepository.Exists(x => x.Title == command.Title))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            
            
            var pictureName = _fileUploader.Upload(command.Picture, slug);
            var publishDate = command.PublishDate.ToGeorgianDateTime();

            var article = new Avent(command.Title, command.Toppic,  pictureName,
                command.PictureAlt, command.PictureTitle, publishDate, slug, command.Keywords, command.MetaDescription
                );

            _aventRepository.Create(article);
            _aventRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditAvent command)
        {
            var operation = new OperationResult();
            var avent = _aventRepository.Get(command.Id);


            var slug = command.Slug.Slugify();

            var pictureName = _fileUploader.Upload(command.Picture, slug);
            var publishDate = command.PublishDate.ToGeorgianDateTime();

           avent.Edit(command.Title, command.Toppic, pictureName,
                command.PictureAlt, command.PictureTitle, publishDate, slug, command.Keywords, command.MetaDescription);

            _aventRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditAvent GetDetails(long id)
        {
            return _aventRepository.GetDetails(id);
        }

        public List<AventViewModel> Search(AventSearchModel searchModel)
        {
            return _aventRepository.Search(searchModel);
        }
    }
}
