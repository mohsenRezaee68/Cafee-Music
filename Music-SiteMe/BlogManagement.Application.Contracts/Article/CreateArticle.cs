using _0_Framework.Application;
using BlogManagement.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Application.Contracts.Article
{
    public class CreateArticle
    {
        [MaxLength(500, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mozo { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }

        

        [MaxLength(500, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [MaxLength(100, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [MaxLength(150, ErrorMessage = ValidationMessages.MaxLenght)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

         [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get; set; }
        public List<ArticleCategoryViewModel> Categories { get; set; }
    }
}
