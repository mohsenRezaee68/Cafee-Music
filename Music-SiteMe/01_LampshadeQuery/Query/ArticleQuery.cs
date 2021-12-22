using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Comment;
using _01_LampshadeQuery.Contracts.Music;
using BlogManagement.Infrastructure.EFCore;
using CommnetManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace _01_LampshadeQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
        }

        public BlogArticleViowMode Articles(int pageId = 1)
        {
            var query = _context.Articles
                .Include(x => x.Category)
              .Where(x => x.Category.Id == 1)

             .Select(music => new ArticleQueryModel
             {
                 Id = music.Id,
                 Mozo = music.Mozo,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 PublishDate = music.CreationDate.ToFarsi(),
                 Slug = music.Slug
             }).AsNoTracking();

           

            var music = query.OrderByDescending(x => x.Id).ToList();

          int take = 25;
            int skip = (pageId - 1) * take;

            BlogArticleViowMode list = new BlogArticleViowMode();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.Articles = music.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            return list;
        }

        public BlogAventViowModel Avents(int pageId = 1)
        {
            var query = _context.Articles
                 .Include(x => x.Category)
               .Where(x => x.Category.Id == 2)

              .Select(music => new ArticleQueryModel
              {
                  Id = music.Id,
                  Mozo = music.Mozo,
                  Picture = music.Picture,
                  PictureAlt = music.PictureAlt,
                  PictureTitle = music.PictureTitle,
                  ShortDescription = music.ShortDescription,
                  PublishDate = music.CreationDate.ToFarsi(),
                  Slug = music.Slug
              }).AsNoTracking();



            var music = query.OrderByDescending(x => x.Id).ToList();

            int take = 25;
            int skip = (pageId - 1) * take;

            BlogAventViowModel list = new BlogAventViowModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(music.Count() / (double)take);

            list.avent = music.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
            return list;
        }

        public ArticleQueryModel GetArticleDetails(long id)
        {
            var avent = _context.Articles
                 .Include(x => x.Category)
                 .Where(x => x.Category.Id ==1)
                 .Where(x => x.IsRemoved == false)
                 .Where(x => x.CreationDate <= DateTime.Now)
                 .Select(x => new ArticleQueryModel
                 {
                     Id = x.Id,
                     Mozo = x.Mozo,
                     CategoryName = x.Category.Name,
                     CategorySlug = x.Category.Slug,
                     Slug = x.Slug,
                    
                     Description = x.Description,
                     Keywords = x.Keywords,
                     MetaDescription = x.MetaDescription,
                     Picture = x.Picture,
                     PictureAlt = x.PictureAlt,
                     PictureTitle = x.PictureTitle,
                     PublishDate = x.CreationDate.ToFarsi(),
                     ShortDescription = x.ShortDescription,
                 }).FirstOrDefault(x => x.Id == id);

            if (!string.IsNullOrWhiteSpace(avent.Keywords))
                avent.KeywordList = avent.Keywords.Split(",").ToList();


            var comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Article)
                .Where(x => x.OwnerRecordName == avent.Mozo)
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

            avent.Comments = comments;

            return avent;
        }

        public ArticleQueryModel GetAventDetails(long id)
        {
            var avent = _context.Articles
               .Include(x => x.Category)
               .Where(x => x.Category.Id == 2)
               .Where(x => x.IsRemoved == false)
               .Where(x => x.CreationDate <= DateTime.Now)
               .Select(x => new ArticleQueryModel
               {
                   Id = x.Id,
                   Mozo = x.Mozo,
                   CategoryName = x.Category.Name,
                   CategorySlug = x.Category.Slug,
                   Slug = x.Slug,
                  
                   Description = x.Description,
                   Keywords = x.Keywords,
                   MetaDescription = x.MetaDescription,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   PublishDate = x.CreationDate.ToFarsi(),
                   ShortDescription = x.ShortDescription,
               }).FirstOrDefault(x => x.Id== id);

            if (!string.IsNullOrWhiteSpace(avent.Keywords))
              avent.KeywordList = avent.Keywords.Split(",").ToList();


            var comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Avent)
                .Where(x => x.OwnerRecordName == avent.Mozo)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    CreationDate =  x.CreationDate.ToFarsi(),
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in comments)
            {
                if (comment.ParentId > 0)
                    comment.parentName = comments.FirstOrDefault(x => x.Id == comment.ParentId)?.Name;
            }

            avent.Comments = comments;

            return avent;
        }

        public List<ArticleQueryModel> LatestArticleAlls()
        {
            var query = _context.Articles
               .Include(x => x.Category)
             .Where(x => x.Category.Id == 1)

            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Mozo = music.Mozo,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.CreationDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
               .Where(x => x.Category.Id == 1)
               .Where(x => x.IsRemoved == false)

               .Select(x => new ArticleQueryModel
               {
                   Id = x.Id,
                   Mozo = x.Mozo,
                   Slug = x.Slug,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   PublishDate = x.CreationDate.ToFarsi(),
                   ShortDescription = x.ShortDescription,


               }).ToList();
        }

        public List<ArticleQueryModel> LatestAventAlls()
        {
            var query = _context.Articles
                .Include(x => x.Category)
              .Where(x => x.Category.Id == 2)
            
             .Select(music => new ArticleQueryModel
             {
                 Id = music.Id,
                 Mozo = music.Mozo,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                 PublishDate = music.CreationDate.ToFarsi(),
                 Slug = music.Slug
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> LatestAvents()
        {
            return _context.Articles
                 .Where(x => x.Category.Id == 2)
                 .Where(x => x.IsRemoved == false)
                  .Select(x => new ArticleQueryModel
                  {
                      Id=x.Id,
                      Mozo = x.Mozo,
                      Slug = x.Slug,
                      Picture = x.Picture,
                      PictureAlt = x.PictureAlt,
                      PictureTitle = x.PictureTitle,
                      PublishDate = x.CreationDate.ToFarsi(),
                      ShortDescription = x.ShortDescription,


                  }).ToList();
        }

        public List<ArticleQueryModel> SearchArticles(string value)
        {

            var query = _context.Articles
            .Include(x => x.Category)
            .Where(x => x.Category.Id == 1)
            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Mozo = music.Mozo,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.CreationDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Mozo.Contains(value)
                || x.Slug.Contains(value) || x.ShortDescription.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> SearchAvents(string value)
        {

            var query = _context.Articles
            .Include(x => x.Category)
            .Where(x=> x.Category.Id == 2)
            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Mozo = music.Mozo,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.CreationDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Mozo.Contains(value)
                || x.Slug.Contains(value) || x.ShortDescription.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }
    }

       
}
