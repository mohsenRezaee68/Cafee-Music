
using _0_Framework.Application;

using MusicManagement.Application.Contracts.Tak;

using MusicManagement.Domain.MusicCategoryAgg;
using MusicManagement.Domain.TakAgg;
using System.Collections.Generic;
using TakManagement.Domain.TakAgg;

namespace TakManagement.Application
{
    public class TakApplication : ITakApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly ITakRepository _takRepository;
        private readonly IMusicCategoryRepository _MusicCategoryRepository;

        public TakApplication(ITakRepository takRepository, IMusicCategoryRepository MusicCategoryRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _takRepository = takRepository;
            _MusicCategoryRepository = MusicCategoryRepository;
        }

        public OperationResult Create(CreateTak command )
        {
            var operation = new OperationResult();
            if (_takRepository.Exists(x => x.Name == command.Name && x.Singer == x.Singer ))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var categorySlug = _MusicCategoryRepository.GetSlugById(command.CategoryId);
            var path = $"{categorySlug}//{slug}";
            var picturePath = _fileUploader.Upload(command.Picture, path);
            var TrackPath = _fileUploader.Upload(command.Trak, path);
            var product = new Tak(command.Name,command.Singer,command.Melyat,command.Sabk,command.Ferestande,
                command.ShortDescription, command.Description, picturePath,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription , TrackPath);
            _takRepository.Create(product);
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

       

        public OperationResult Edit(EditTak command)
        {
            var operation = new OperationResult();
            var product = _takRepository.GetWithCategory(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_takRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var path = $"{product.Category.Slug}/{slug}";
            var TrackPath = _fileUploader.Upload(command.Trak, path);
            var picturePath = _fileUploader.Upload(command.Picture, path);
            product.Edite(command.Name, command.Singer, command.Melyat, command.Sabk, command.Ferestande,
                command.ShortDescription, command.Description, picturePath,
                command.PictureAlt, command.PictureTitle, command.CategoryId, slug,
                command.Keywords, command.MetaDescription, TrackPath);

            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditTak GetDetails(long id)
        {
            return _takRepository.GetDetails(id);
        }

       


        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var music = _takRepository.Get(id);
            if (music == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            music.Remove();
            _takRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var music = _takRepository.Get(id);
            if (music == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            music.Restore();
            _takRepository.SaveChanges();
            return operation.Succedded();
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

        public List<TakViewModel> Search(TakSearchModel searchModel)
        {
            return _takRepository.Search(searchModel);
        }

        
    }
}
