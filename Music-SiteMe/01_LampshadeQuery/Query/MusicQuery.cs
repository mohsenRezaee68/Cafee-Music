
using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Comment;
using _01_LampshadeQuery.Contracts.Music;
using ArtistManagement.Infrastructure.EFCore;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

using MusicManagement.Domain.MusicTrackAgg;
using MusicManagement.Infrastructure.EFCore;
using System.Collections.Generic;
using System.Linq;

namespace _01_LampshadeQuery.Query
{
    public class MusicQuery : IMusicQuery
    {
        private readonly MusicContext _context;
        private readonly CommentContext _commentContext;
        private readonly ArtistContext _artistContext;
        public MusicQuery(MusicContext context, CommentContext commentContext , ArtistContext artistContext)
        {
            _context = context;
            _commentContext = commentContext;
            _artistContext = artistContext;
        }

        public List<MusicQueryModel> GetAlbomMusics()
        {
            return _context.Musics
                .Where(x => x.Category.Id == 12)
                .Where(x => x.IsRemoved == false)
              
                .Select(x => new MusicQueryModel 
                { 
                    Id = x.Id,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Sabk = x.Sabk,
                    Singer = x.Singer,
                    Name = x.Name,
                    Slug = x.Singer
                }).OrderByDescending(x => x.Id).Take(12).ToList();
        }

        private static List<MusicTrackQueryModel> MapMusicTracks(List<MusicTrack> Tracks)
        {
            return Tracks.Select(x => new MusicTrackQueryModel
            {
                IsRemoved = x.IsRemoved,
                Track = x.Track,
                TrackName = x.TrackName,
            }).Where(x => !x.IsRemoved).ToList();
        }

        public MusicQueryModel GetAlbomDetails(long Id)
        {
            var albom = _context.Musics
               .Include(x => x.Category)

               .Include(x => x.MusicTracks)
               .Select(x => new MusicQueryModel
               {
                   Id = x.Id,

                   Name = x.Name,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   Slug = x.Slug,
                   Singer = x.Singer,
                   Catgory = x.Category.Name,
                   Dawnlod = x.Dawnlod,
                   Description = x.Description,
                   Keywords = x.Keywords,
                   MetaDescription = x.MetaDescription,
                   ShortDescription = x.ShortDescription,

                   Tracks = MapMusicTracks(x.MusicTracks),

               }).FirstOrDefault(x => x.Id == Id);

            albom.Comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Albom)
                .Where(x => x.OwnerRecordId == albom.Id)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name

                }).OrderByDescending(X => X.Id).ToList();
            return albom;
        }


        //-----------------همه اهنگ ها ----------------------
       

      

        public List<MusicQueryModel> SearchAlbom(string value)
        {
          

           var  query = _context.Musics
                 
                .Include(x => x.Category)
               
                .Select(music => new MusicQueryModel
                {
                    Id = music.Id,
                    Catgory = music.Category.Name,
                    CategorySlug = music.Category.Slug,
                    Name = music.Name,
                    Picture = music.Picture,
                    PictureAlt = music.PictureAlt,
                    PictureTitle = music.PictureTitle,
                    ShortDescription = music.ShortDescription,
                   Dawnlod=music.Dawnlod,
                    Singer = music.Singer,
                    Melyat = music.Melyat,
                    Sabk = music.Sabk,
                    Slug = music.Singer
                }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value) 
                || x.Singer.Contains(value) || x.Melyat.Contains(value) || x.Sabk.Contains(value)
                );

             var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }


        public List<MusicQueryModel> SearchTrack(string value)
        {

                     var  query = _context.Taks
                     .Include(x => x.Category)
                     .Where(x => x.Sabk != "مذهبی")
                     .Select(music => new MusicQueryModel
                     {
                         Id = music.Id,
                         Catgory = music.Category.Name,
                         CategorySlug = music.Category.Slug,
                         Name = music.Name,
                         Picture = music.Picture,
                         PictureAlt = music.PictureAlt,
                         PictureTitle = music.PictureTitle,
                         ShortDescription = music.ShortDescription,
                         Track = music.Trak,
                         Singer = music.Singer,
                         Melyat = music.Melyat,
                         Sabk = music.Sabk,
                         Slug = music.Slug
                     }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value)
                || x.Singer.Contains(value) || x.Melyat.Contains(value) || x.Sabk.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> GetAllAlbomMusics()
        {
            var query = _context.Musics
                .Where(x=> x.Sabk != "مذهبی")
               .Include(x => x.Category)
               .Select(music => new MusicQueryModel
               {
                   Id = music.Id,
                   Catgory = music.Category.Name,
                   CategorySlug = music.Category.Slug,
                   Name = music.Name,
                   Picture = music.Picture,
                   PictureAlt = music.PictureAlt,
                   PictureTitle = music.PictureTitle,
                   ShortDescription = music.ShortDescription,

                   Singer = music.Singer,
                   Melyat = music.Melyat,
                   Sabk = music.Sabk,
                   Slug = music.Singer
               }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace("آلبوم"))
                query = query.Where(x => x.Catgory.Contains("آلبوم"));

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> GetMusicDetails()
        {
            return _context.Taks

               
               .Where(x => x.IsRemoved == false)

               .Select(x => new MusicQueryModel
               {
                   Id = x.Id,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   Sabk = x.Sabk,
                   Singer = x.Singer,
                   Name = x.Name,
                   Track = x.Trak,
                   Melyat = x.Melyat,
                   Slug = x.Singer
                   
               }).OrderByDescending(x => x.Id).Take(6).ToList();



        }

        public List<MusicQueryModel> GetAllTrackss()
        {
            var query = _context.Taks
               .Where(x => x.Sabk != "مذهبی")
              .Include(x => x.Category)
              .Select(music => new MusicQueryModel
              {
                  Id = music.Id,
                  Catgory = music.Category.Name,
                  CategorySlug = music.Category.Slug,
                  Name = music.Name,
                  Picture = music.Picture,
                  PictureAlt = music.PictureAlt,
                  PictureTitle = music.PictureTitle,
                  ShortDescription = music.ShortDescription,
                  Track = music.Trak,
                  Singer = music.Singer,
                  Melyat = music.Melyat,
                  Sabk = music.Sabk,
                  Slug = music.Singer
              }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> GetAllTracksMazhabi()
        {
            var query = _context.Taks
              .Where(x => x.Sabk == "مذهبی")
             .Include(x => x.Category)
             .Select(music => new MusicQueryModel
             {
                 Id = music.Id,
                 Catgory = music.Category.Name,
                 CategorySlug = music.Category.Slug,
                 Name = music.Name,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 Track = music.Trak,
                 Singer = music.Singer,
                 Melyat = music.Melyat,
                 Sabk = music.Sabk,
                 Slug = music.Singer
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> SearchMazhabi(string value)
        {

            var query = _context.Taks
            .Include(x => x.Category)
            .Where(x => x.Sabk == "مذهبی")
            .Select(music => new MusicQueryModel
            {
                Id = music.Id,
                Catgory = music.Category.Name,
                CategorySlug = music.Category.Slug,
                Name = music.Name,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                Track = music.Trak,
                Singer = music.Singer,
                Melyat = music.Melyat,
                Sabk = music.Sabk,
                Slug = music.Singer
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Name.Contains(value)
                || x.Singer.Contains(value) || x.Melyat.Contains(value) || x.Sabk.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> GetLatestArrivals()
        {
            throw new System.NotImplementedException();
        }

        public List<MusicQueryModel> ArshivMusic()
        {
            var query = _context.Taks
             
             .Include(x => x.Category)
             .Select(music => new MusicQueryModel
             {
                 Id = music.Id,
                 Catgory = music.Category.Name,
                 CategorySlug = music.Category.Slug,
                 Name = music.Name,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 Track = music.Trak,
                 Singer = music.Singer,
                 Melyat = music.Melyat,
                 Sabk = music.Sabk,
                 Slug = music.Singer
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> ArshivIrani()
        {
            var query = _context.Taks
             .Where(x => x.Melyat=="ایرانی"  || x.Melyat == "ایران")
            .Include(x => x.Category)
            .Select(music => new MusicQueryModel
            {
                Id = music.Id,
                Catgory = music.Category.Name,
                CategorySlug = music.Category.Slug,
                Name = music.Name,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                Track = music.Trak,
                Singer = music.Singer,
                Melyat = music.Melyat,
                Sabk = music.Sabk,
                Slug = music.Singer
            }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> ArshivAfg()
        {
            var query = _context.Taks
              .Where(x => x.Melyat == "افغانستانی" || x.Melyat == "افغانستان")
             .Include(x => x.Category)
             .Select(music => new MusicQueryModel
             {
                 Id = music.Id,
                 Catgory = music.Category.Name,
                 CategorySlug = music.Category.Slug,
                 Name = music.Name,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 Track = music.Trak,
                 Singer = music.Singer,
                 Melyat = music.Melyat,
                 Sabk = music.Sabk,
                 Slug = music.Singer
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<MusicQueryModel> ArshivMenal()
        {
            var query = _context.Taks
              .Where(x => x.Melyat != "افغانستانی" || x.Melyat != "افغانستان")
             .Include(x => x.Category)
             .Select(music => new MusicQueryModel
             {
                 Id = music.Id,
                 Catgory = music.Category.Name,
                 CategorySlug = music.Category.Slug,
                 Name = music.Name,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 Track = music.Trak,
                 Singer = music.Singer,
                 Melyat = music.Melyat,
                 Sabk = music.Sabk,
                 Slug = music.Singer
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }
    }
}