using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Artist;
using _01_LampshadeQuery.Contracts.Comment;
using ArtistManagement.Infrastructure.EFCore;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _01_LampshadeQuery.Query
{
    public class ArtistQuery : IArtistQuery
    {
        private readonly ArtistContext _context;
        private readonly CommentContext _commentContext;
       
        public ArtistQuery(ArtistContext context, CommentContext commentContext )
        {
            _context = context;
            _commentContext = commentContext;
           
        }

        public ArtistsViowMode Artist(int pageId = 1)
        {
            var query = _context.Artists

                .Where(x => x.IsRemoved == false)

                .Select(x => new ArtistQueryModel
                {
                    Id = x.Id,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Name = x.Name,
                    Laghab = x.Laghab
                }).AsNoTracking();
            

           



            var music = query.OrderByDescending(x => x.Id).ToList();

            int take = 24;
            int skip = (pageId - 1) * take;

            ArtistsViowMode list = new ArtistsViowMode();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.Artists = music.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            return list;
        }

        public ArtistQueryModel GetArtistDetails(string Laghab)
        {
            
            var artist = _context.Artists
                
                .Where(x => x.IsRemoved == false)
               .Select(x => new ArtistQueryModel
               {
                   Name = x.Name,
                   Id = x.Id,
                   Laghab = x.Laghab,
                   Slug = x.Slug,
                    Text = x.Text,
                   Keywords = x.Keywords,
                   MetaDescription = x.MetaDescription,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                  
               }).FirstOrDefault(x => x.Laghab == Laghab);
           
                if (!string.IsNullOrWhiteSpace(artist.Keywords))
                    artist.KeywordList = artist.Keywords.Split(",").ToList();
                var comments = _commentContext.Comments

                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Artist)
                .Where(x => x.OwnerRecordSinger == artist.Laghab)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi(),

                }).OrderByDescending(x => x.Id).ToList();

                foreach (var comment in comments)
                {
                    if (comment.ParentId > 0)
                        comment.parentName = comments.FirstOrDefault(x => x.Id == comment.ParentId)?.Name;
                }

                artist.Comments = comments;
           
          
              return artist;
        }

        public List<ArtistQueryModel> LatestArtistAlls()
        {

            var query = _context.Artists
             .Select(music => new ArtistQueryModel
             {
                 Id = music.Id,
                 Slug = music.Slug,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 Name = music.Name,
                 Laghab = music.Laghab
             }).AsNoTracking();

            var music = query.ToList();

            return music;
        }

        public List<ArtistQueryModel> LatestArtists()
        {
           var query = _context.Artists
                
                .Where(x => x.IsRemoved == false)
               
                .Select(x => new ArtistQueryModel
                {
                   Id=x.Id,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                   Name=x.Name,
                   Laghab = x.Laghab
                }).AsNoTracking();
                  var music = query.OrderByDescending(x => x.Id).Take(20).ToList();
            
            return music;
        }

        public List<ArtistQueryModel> SearchArtists(string value)
        {
            var query = _context.Artists
           
           .Select(music => new ArtistQueryModel
           {
               Id = music.Id,
               Name = music.Name,
               Laghab = music.Laghab,
               Slug = music.Slug,
               Text = music.Text,
               Keywords = music.Keywords,
               MetaDescription = music.MetaDescription,
               Picture = music.Picture,
               PictureAlt = music.PictureAlt,
               PictureTitle = music.PictureTitle,
           }).AsNoTracking();
            if(query != null)
            {
                if (!string.IsNullOrWhiteSpace(value))
                    query = query.Where(x => x.Laghab.Contains(value) || x.Name.Contains(value));
   
            }

            var music = query.OrderByDescending(x => x.Id).ToList();
            return music;
        }
    }
}
