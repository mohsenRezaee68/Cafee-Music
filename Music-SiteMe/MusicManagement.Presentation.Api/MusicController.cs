using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Mvc;

namespace MusicManagement.Presentation.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicQuery _musicQuery;

        public MusicController(IMusicQuery musicQuery)
        {
            _musicQuery = musicQuery;
        }

      
    }
}