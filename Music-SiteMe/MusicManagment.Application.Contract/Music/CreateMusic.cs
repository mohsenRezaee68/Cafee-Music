

using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using MusicManagement.Application.Contracts.MusicCategory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicManagement.Application.Contracts.Music
{
    public class CreateMusic
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get;  set; }
       
        
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Singer { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Melyat { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Sabk { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Ferestande { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string ShortDescription { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Description { get;  set; }

        [MaxFileSize(1 * 1024 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile Picture { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureAlt { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PictureTitle { get;  set; }

        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long CategoryId { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get;  set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get;  set; }
        public List<MusicCategoryViewModel> Categories { get; set; }
    }
}
