

using _0_Framework.Application;
using musicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Application.Contracts.MusicTrack;
using MusicManagement.Domain.MusicAgg;
using MusicManagement.Domain.MusicTrackAgg;
using System.Collections.Generic;

namespace MusicManagement.Application
{
    public class MusicTrackApplication : IMusicTrackApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IMusicRepository _musicRepository;
        private readonly IMusicTrackRepository _musicTrackRepository;

        public MusicTrackApplication(IMusicTrackRepository musicTrackRepository, IMusicRepository musicRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _musicRepository = musicRepository;
            _musicTrackRepository = musicTrackRepository;
        }

        public OperationResult Create(CreateMusicTrack command)
        {
            var operation = new OperationResult();
            

            var product = _musicRepository.GetMusicWithCategory(command.TrackId);

            var path = $"{product.Category.Slug}//{product.Category.Slug}";
            var picturePath = _fileUploader.Upload(command.Track, path);

            var musictrack = new MusicTrack( picturePath, command.TrackId);
            _musicTrackRepository.Create(musictrack);
            _musicTrackRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditMusicTrack command)
        {
            var operation = new OperationResult();
            var productPicture = _musicTrackRepository.GetWithMusicAndCategory(command.Id);
            if (productPicture == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var path = $"{productPicture.Music.Category.Slug}//{productPicture.Music.Slug}";
            var picturePath = _fileUploader.Upload(command.Track, path);

            productPicture.Edit( picturePath, command.TrackId);
            _musicTrackRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditMusicTrack GetDetails(long id)
        {
            return _musicTrackRepository.GetDetails(id);
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var musicTrack = _musicTrackRepository.Get(id);
            if (musicTrack == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            musicTrack.Remove();
            _musicTrackRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var musicTrack = _musicTrackRepository.Get(id);
            if (musicTrack == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            musicTrack.Restore();
            _musicTrackRepository.SaveChanges();
            return operation.Succedded();
        }


       public List<MusicTrackViewModel> Search(MusicTrackSearchModel searchModel)
        {
            return _musicTrackRepository.Search(searchModel);
        }
    }
}
