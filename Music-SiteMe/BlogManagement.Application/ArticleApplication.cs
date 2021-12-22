

using _0_Framework.Application;
using BlogManagement.Application.Contracts.Article;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;

namespace BlogManagement.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        public ArticleApplication(IArticleRepository articleRepository, IFileUploader fileUploader,
            IArticleCategoryRepository articleCategoryRepository)
        {
            _fileUploader = fileUploader;
            _articleRepository = articleRepository;
            _articleCategoryRepository = articleCategoryRepository;
        }

        public OperationResult Create(CreateArticle command)
        {
            var operation = new OperationResult();
            if (_articleRepository.Exists(x => x.Mozo == command.Mozo))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var categorySlug = _articleCategoryRepository.GetSlugBy(command.CategoryId);
            var path = $"{categorySlug}/{slug}";
            var pictureName = _fileUploader.Upload(command.Picture, path);
           
            var article = new Article(command.Mozo, command.ShortDescription, command.Description, pictureName,
                command.PictureAlt, command.PictureTitle,slug, command.Keywords, command.MetaDescription,
                command.CategoryId);

            _articleRepository.Create(article);
            _articleRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditArticle command)
        {
            var operation = new OperationResult();
            var product = _articleRepository.GetWithCategory(command.Id);
            if (product == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_articleRepository.Exists(x => x.Mozo == command.Mozo && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var slug = command.Slug.Slugify();
            var path = $"{product.Category.Slug}/{slug}";

            var picturePath = _fileUploader.Upload(command.Picture, path);
            product.Edit(command.Mozo, command.ShortDescription, command.Description, picturePath,
                command.PictureAlt, command.PictureTitle, slug, command.Keywords, command.MetaDescription,
                command.CategoryId);

            _articleRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditArticle GetDetails(long id)
        {
            return _articleRepository.GetDetails(id);
        }

        public List<ArticleViewModel> Search(ArticleSearchModel searchModel)
        {
            return _articleRepository.Search(searchModel);
        }
         public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var slide = _articleRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            _articleRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var slide = _articleRepository.Get(id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            _articleRepository.SaveChanges();
            return operation.Succedded();
        }
    }
}
