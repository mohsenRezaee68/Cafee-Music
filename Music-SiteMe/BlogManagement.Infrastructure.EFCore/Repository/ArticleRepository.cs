
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogManagement.Infrastructure.EFCore.Repository
{
    public class ArticleRepository : RepositoryBase<long, Article>, IArticleRepository
    {
        private readonly BlogContext _context;

        public ArticleRepository(BlogContext context) : base(context)
        {
            _context = context;
        }

        public EditArticle GetDetails(long id)
        {
            return _context.Articles
                .Include(x => x.Category)
                .Select(x => new EditArticle
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription,
                Slug = x.Slug,
                Mozo = x.Mozo,
            }).FirstOrDefault(x => x.Id == id);
        }

        public Article GetWithCategory(long id)
        {
            return _context.Articles
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            var query = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                Category = x.Category.Name,
                Picture = x.Picture,
               
                IsRemoved = x.IsRemoved,
                ShortDescription = x.ShortDescription.Substring(0, Math.Min(x.ShortDescription.Length, 50)) + " ...",
                CreationDate  = x.CreationDate.ToFarsi(),
                Mozo = x.Mozo
            }) ;

            if (!string.IsNullOrWhiteSpace(searchModel.Mozo))
                query = query.Where(x => x.Mozo.Contains(searchModel.Mozo));

            if (searchModel.CategoryId > 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
