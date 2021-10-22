using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MusicManagement.Application.Contracts.MusicCategory
{
    public class CreateMusicCategory
    {
       [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        public string Description { get; set; }

        
       [FileExtentionLimitation(new string[] { ".jpeg", ".jpg", ".png" }, ErrorMessage = ValidationMessages.InvalidFileFormat)]
        [MaxFileSize(3 * 1024 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile Picture { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }
    }
}
