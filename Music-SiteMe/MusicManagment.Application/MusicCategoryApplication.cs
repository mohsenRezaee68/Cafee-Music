

using _0_Framework.Application;
using MusicManagement.Application.Contracts.MusicCategory;
using MusicManagement.Domain.MusicCategoryAgg;
using System.Collections.Generic;

namespace MusicManagement.Application
{
    public class MusicCategoryApplication : IMusicCategoryApplication
    {
        private readonly IMusicCategoryRepository _MusicCategoryRepostory;
        private readonly IFileUploader _fileUploader;
        public MusicCategoryApplication(IMusicCategoryRepository MusicCategoryRepostory, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _MusicCategoryRepostory = MusicCategoryRepostory;
        }
        public OperationResult Create(CreateMusicCategory command)
        {
            var operation = new OperationResult();
            if (_MusicCategoryRepostory.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();

            var picturePath = $"{command.Slug}";
            var pictureName = _fileUploader.Upload(command.Picture, picturePath);

            var productCategory = new MusicCategory(command.Name, command.Description,
                pictureName, command.PictureAlt, command.PictureTitle, command.Keywords,
                command.MetaDescription, slug);

            _MusicCategoryRepostory.Create(productCategory);
            _MusicCategoryRepostory.SaveChanges();
            return operation.Succedded();
        }
        public OperationResult Edit(EditMusicCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _MusicCategoryRepostory.Get(command.Id);

            if (productCategory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_MusicCategoryRepostory.Exists(x => x.Name == command.Name && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();

            var picturePath = $"{command.Slug}";
            var fileName = _fileUploader.Upload(command.Picture, picturePath);

            productCategory.Edit(command.Name, command.Description, fileName,
                command.PictureAlt, command.PictureTitle, command.Keywords,
                command.MetaDescription, slug);

            _MusicCategoryRepostory.SaveChanges();
            return operation.Succedded();
        }
        public EditMusicCategory GetDetails(long id)
        {
            return _MusicCategoryRepostory.GetDetails(id);
        }

        public List<MusicCategoryViewModel> GetMusicCategories()
        {
            return _MusicCategoryRepostory.GetMusicCategories();
        }
        public List<MusicCategoryViewModel> Search(MusicCategorySearchModel searchModel)
        {
            return _MusicCategoryRepostory.Search(searchModel);
        }
    }
}
