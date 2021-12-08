

using _0_Framework.Application;
using ArtistManagement.Application.Contracts.Artist;
using ArtistManagement.Domain.ArtistAgg;

using System.Collections.Generic;

namespace ArtistManagement.Application
{
    public class ArtistApplication : IArtistApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IArtistRepository _artistRepository;

        public ArtistApplication(IArtistRepository artistRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _artistRepository = artistRepository;
        }

        public OperationResult Create(CreateArtist command)
        {
            var operation = new OperationResult();
            if (_artistRepository.Exists(x => x.Laghab == command.Laghab))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);
            
            var slug = command.Slug.Slugify();
            var pictureName = _fileUploader.Upload(command.Picture, slug);
             var slide = new Artist(pictureName, command.PictureAlt, command.PictureTitle,
                command.Laghab, command.Text, command.Name, command.ShertText , command.Slug, command.Keywords,command.MetaDescription);

            _artistRepository.Create(slide);
            _artistRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditArtist command)
        {
            var operation = new OperationResult();
            var artist = _artistRepository.Get(command.Id);
            if (artist == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            var slug = command.Slug.Slugify();
            var pictureName = _fileUploader.Upload(command.Picture, slug);

            artist.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Laghab, command.Text, command.Name, command.ShertText, command.Slug, command.Keywords, command.MetaDescription);
            _artistRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditArtist GetDetails(long id)
        {
            return _artistRepository.GetDetails(id);
        }

        public List<ArtistViewModel> GetList()
        {
            return _artistRepository.GetList();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var slide = _artistRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            _artistRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _artistRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            _artistRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<ArtistViewModel> Search(ArtistSearchModel searchModel)
        {
            return _artistRepository.Search(searchModel);
        }
    }
}
