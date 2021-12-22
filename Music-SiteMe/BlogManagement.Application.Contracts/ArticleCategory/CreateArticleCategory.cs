using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Application.Contracts.ArticleCategory
{
    public class CreateArticleCategory
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }
        
        public IFormFile Picture { get; set; }

      [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

      

     
    }
}
