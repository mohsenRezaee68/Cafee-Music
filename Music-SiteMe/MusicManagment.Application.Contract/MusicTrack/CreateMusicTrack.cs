

using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using MusicManagement.Application.Contracts.Music;
using MusicManagement.Application.Contracts.MusicCategory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicManagement.Application.Contracts.MusicTrack
{
    public class CreateMusicTrack
    {
       
       
        public long TrackId { get; set; }
        
        public IFormFile Track { get; set; }

        
       

       
      
        public List<MusicViewModel> Musics { get; set; }
    }
}

