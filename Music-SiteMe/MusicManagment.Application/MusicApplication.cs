
using _0_Framework.Application;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicCategoryAgg;
using System.Collections.Generic;

namespace MusicManagement.Application
{
    public class MusicApplication : IMusicApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IMusicRepository _MusicRepository;
        private readonly IMusicCategoryRepository _MusicCategoryRepository;

        public MusicApplication(IMusicRepository MusicRepository, IMusicCategoryRepository MusicCategoryRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _MusicRepository = MusicRepository;
            _MusicCategoryRepository = MusicCategoryRepository;
        }

        public OperationResult Create(CreateMusic command)
        {
            var operation = new OperationResult();
            if (_MusicRepository.Exists(x => x.Name == command.Name && x.Singer == x.Singer ))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var categorySlug = _MusicCategoryRepository.GetSlugById(command.CategoryId);
            var path = $"{categorySlug}//{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);
            var product = new Music(command.Name,command.Singer,command.Sabk,command.Melyat,command.Ferestande,
                command.ShortDescription, command.Description, picturePath,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription);
            _MusicRepository.Create(product);
            _MusicRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditMusic command)
        {
            var operation = new OperationResult();
            var product = _MusicRepository.GetMusicWithCategory(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_MusicRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var path = $"{product.Category.Slug}/{slug}";

            var picturePath = _fileUploader.Upload(command.Picture, path);
            product.Edite(command.Name, command.Singer, command.Sabk, command.Melyat, command.Ferestande,
                command.ShortDescription, command.Description, picturePath,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription);

            _MusicRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditMusic GetDetails(long id)
        {
            return _MusicRepository.GetDetails(id);
        }

        public List<MusicViewModel> GetMusic()
        {
            return _MusicRepository.GetMusics();
        }

     //   public OperationResult IsStock(long id)
     //   {
     //       
     //       var operation = new OperationResult();
     //       var product = _productRepository.Get(id);
     //       
     //      
     //           return operation.Failed(ApplicationMessages.DuplicatedRecord);
     //
     //       product.InStock();
     //       _productRepository.SaveChanges();
     //       return operation.Succedded();
     //   }
     //
     //   public OperationResult NotInStock(long id)
     //   {
     //       var operation = new OperationResult();
     //       var product = _productRepository.Get(id);
     //
     //
     //       return operation.Failed(ApplicationMessages.DuplicatedRecord);
     //
     //       product.NotIdstock();
     //       _productRepository.SaveChanges();
     //       return operation.Succedded();
     //   }

        public List<MusicViewModel> Search(MusicSearchModel searchModel)
        {
            return _MusicRepository.Search(searchModel);
        }
    }
}
