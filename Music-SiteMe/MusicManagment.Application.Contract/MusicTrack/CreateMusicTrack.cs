using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using MusicManagement.Application.Contracts.Music;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicManagement.Application.Contracts.MusicTrack
{
    public class CreateMusicTrack
    {
        [Range(1, 1000000, ErrorMessage = ValidationMessages.IsRequired)]
        public long TrackId { get; set; } 
        
        public IFormFile Track { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string TrackName { get; set; }

        public long CategoryId { get; set; }
         public List<MusicViewModel> Musics { get; set; }
    }
}

