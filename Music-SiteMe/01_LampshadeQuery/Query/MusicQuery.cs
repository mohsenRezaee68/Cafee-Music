
using _0_Framework.Application;
using _0_Framework.Domain;
using _0_Framework.Infrastructure;
using _01_LampshadeQuery.Contracts.Comment;
using _01_LampshadeQuery.Contracts.Music;
using ArtistManagement.Infrastructure.EFCore;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

using MusicManagement.Domain.MusicTrackAgg;
using MusicManagement.Infrastructure.EFCore;
using System;
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
                    Melyat = x.Melyat,
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
                .Where(x => x.OwnerRecordName == albom.Name)
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

   

        public List<MusicQueryModel> GetMusicDetails()
        {
            return _context.Taks
                .Include(x => x.Category)
           .Where(x => x.Melyat == "افغانستان" && x.Sabk != "مذهبی")
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
        public List<MusicQueryModel> GetMusicmenallDetails()
        {
            return _context.Taks
                .Include(x => x.Category)
           .Where(x => x.Melyat != "افغانستان" && x.Sabk != "مذهبی")
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
        public List<MusicQueryModel> GetMusicmazhabiDetails()
        {
            return _context.Taks
                .Include(x => x.Category)
           .Where(x =>  x.Sabk == "مذهبی")
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
                .Where(x => x.IsRemoved == false)
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
               .Where(x => x.IsRemoved == false)
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
             .Where(x => x.IsRemoved == false)
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

        public MohsenViowModel mohsenViowModel(int pageId = 1)
        {
            var query = _context.Musics
              .Where(x => x.Sabk != "مذهبی")
               .Where(x => x.IsRemoved == false)
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

            //  return music;


            int take = 18;
            int skip = (pageId - 1) * take;

            MohsenViowModel list = new MohsenViowModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.Alboms = music.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            return list;



            //  IQueryable<MusicQueryModel> result = (IQueryable<MusicQueryModel>)_context.Musics;
            //  int take = 2;
            //  int skip = (pageId - 1) * take;
            //
            //  MohsenViowModel list = new MohsenViowModel();
            //  list.CurrentPage = pageId;
            //  list.PageCount = (int)Math.Ceiling(result.Count() / (double)take);
            //
            //  list.Alboms = result.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            //  return list;
        }

        public takViewforadmin AllMusicTak(int pageId = 1 )
        {
            var query = _context.Taks
             
            .Include(x => x.Category)
            .Where(x=> x.Sabk != "مذهبی")
             .Where(x => x.IsRemoved == false)
            .Select(music => new TakViewForModel
            {
                Id = music.Id,
                Category = music.Category.Name,
                CategorySlug = music.Category.Slug,
                NameMusic = music.Name,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                Trak = music.Trak,
                Singer = music.Singer,
                Melyat = music.Melyat,
                Sabk = music.Sabk,
                Slug = music.Singer

            }).AsNoTracking();

          
            var music = query.OrderByDescending(x => x.Id).ToList();

            //  return music;


            int take = 10;
            int skip = (pageId - 1) * take;

            takViewforadmin list = new takViewforadmin();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.Musics = music.Skip(skip).Take(take).ToList();
            return list;
        }

        public takViewforadmin MazhabiTak(int pageId = 1)
        {
            var query = _context.Taks

            .Include(x => x.Category)
            .Where(x=>x.Sabk =="مذهبی")
             .Where(x => x.IsRemoved == false)
            .Select(music => new TakViewForModel
            {

                Id = music.Id,
                Category = music.Category.Name,
                CategorySlug = music.Category.Slug,
                NameMusic = music.Name,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                Trak = music.Trak,
                Singer = music.Singer,
                Melyat = music.Melyat,
                Sabk = music.Sabk,
                Slug = music.Singer

            }).AsNoTracking();


            var music = query.OrderByDescending(x => x.Id).ToList();

            //  return music;


            int take = 10;
            int skip = (pageId - 1) * take;

            takViewforadmin list = new takViewforadmin();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.Musics = music.Skip(skip).Take(take).ToList();
            return list;
        }

       
    }
}