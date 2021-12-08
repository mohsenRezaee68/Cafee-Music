using _0_Framework.Application;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Comment;
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

        public ArticleQueryModel GetArticleDetails(long id)
        {
            var avent = _context.Articles
                 .Include(x => x.Category)
                 .Where(x => x.Category.Id ==5)
                 .Where(x => x.IsRemoved == false)
                 .Where(x => x.PublishDate <= DateTime.Now)
                 .Select(x => new ArticleQueryModel
                 {
                     Id = x.Id,
                     Title = x.Title,
                     CategoryName = x.Category.Name,
                     CategorySlug = x.Category.Slug,
                     Slug = x.Slug,
                     CanonicalAddress = x.CanonicalAddress,
                     Description = x.Description,
                     Keywords = x.Keywords,
                     MetaDescription = x.MetaDescription,
                     Picture = x.Picture,
                     PictureAlt = x.PictureAlt,
                     PictureTitle = x.PictureTitle,
                     PublishDate = x.PublishDate.ToFarsi(),
                     ShortDescription = x.ShortDescription,
                 }).FirstOrDefault(x => x.Id == id);

            if (!string.IsNullOrWhiteSpace(avent.Keywords))
                avent.KeywordList = avent.Keywords.Split(",").ToList();


            var comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Article)
                .Where(x => x.OwnerRecordId == avent.Id)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
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
               .Where(x => x.Category.Id == 4)
               .Where(x => x.IsRemoved == false)
               .Where(x => x.PublishDate <= DateTime.Now)
               .Select(x => new ArticleQueryModel
               {
                   Id = x.Id,
                   Title = x.Title,
                   CategoryName = x.Category.Name,
                   CategorySlug = x.Category.Slug,
                   Slug = x.Slug,
                   CanonicalAddress = x.CanonicalAddress,
                   Description = x.Description,
                   Keywords = x.Keywords,
                   MetaDescription = x.MetaDescription,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   PublishDate = x.PublishDate.ToFarsi(),
                   ShortDescription = x.ShortDescription,
               }).FirstOrDefault(x => x.Id== id);

            if (!string.IsNullOrWhiteSpace(avent.Keywords))
              avent.KeywordList = avent.Keywords.Split(",").ToList();


            var comments = _commentContext.Comments
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Where(x => x.Type == CommentType.Avent)
                .Where(x => x.OwnerRecordId == avent.Id)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Message = x.Message,
                    Name = x.Name,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
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
             .Where(x => x.Category.Id == 5)

            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Title = music.Title,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.PublishDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
               .Where(x => x.Category.Id == 5)
               .Where(x => x.IsRemoved == false)

               .Select(x => new ArticleQueryModel
               {
                   Id = x.Id,
                   Title = x.Title,
                   Slug = x.Slug,
                   Picture = x.Picture,
                   PictureAlt = x.PictureAlt,
                   PictureTitle = x.PictureTitle,
                   PublishDate = x.PublishDate.ToFarsi(),
                   ShortDescription = x.ShortDescription,


               }).ToList();
        }

        public List<ArticleQueryModel> LatestAventAlls()
        {
            var query = _context.Articles
                .Include(x => x.Category)
              .Where(x => x.Category.Id == 4)
            
             .Select(music => new ArticleQueryModel
             {
                 Id = music.Id,
               Title = music.Title,
                 Picture = music.Picture,
                 PictureAlt = music.PictureAlt,
                 PictureTitle = music.PictureTitle,
                 ShortDescription = music.ShortDescription,
                  PublishDate=music.PublishDate.ToFarsi(),
                 Slug = music.Slug
             }).AsNoTracking();

            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> LatestAvents()
        {
            return _context.Articles
                 .Where(x => x.Category.Id == 4)
                 .Where(x => x.IsRemoved == false)
                  .Select(x => new ArticleQueryModel
                  {
                      Id=x.Id,
                      Title = x.Title,
                      Slug = x.Slug,
                      Picture = x.Picture,
                      PictureAlt = x.PictureAlt,
                      PictureTitle = x.PictureTitle,
                      PublishDate = x.PublishDate.ToFarsi(),
                      ShortDescription = x.ShortDescription,


                  }).ToList();
        }

        public List<ArticleQueryModel> SearchArticles(string value)
        {

            var query = _context.Articles
            .Include(x => x.Category)
            .Where(x => x.Category.Id == 5)
            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Title = music.Title,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.PublishDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Title.Contains(value)
                || x.Slug.Contains(value) || x.ShortDescription.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }

        public List<ArticleQueryModel> SearchAvents(string value)
        {

            var query = _context.Articles
            .Include(x => x.Category)
            .Where(x=> x.Category.Id == 4)
            .Select(music => new ArticleQueryModel
            {
                Id = music.Id,
                Title = music.Title,
                Picture = music.Picture,
                PictureAlt = music.PictureAlt,
                PictureTitle = music.PictureTitle,
                ShortDescription = music.ShortDescription,
                PublishDate = music.PublishDate.ToFarsi(),
                Slug = music.Slug
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(value))
                query = query.Where(x => x.Title.Contains(value)
                || x.Slug.Contains(value) || x.ShortDescription.Contains(value)
                );


            var music = query.OrderByDescending(x => x.Id).ToList();

            return music;
        }
    }

       
}
