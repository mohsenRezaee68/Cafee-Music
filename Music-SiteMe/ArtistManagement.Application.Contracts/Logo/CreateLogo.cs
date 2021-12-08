

using _0_Framework.Application;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ArtistManagement.Application.Contracts.Logo
{
    public class CreateLogo
    {
        public IFormFile Picture { get; set; }
        public string NameSite { get; set; }
    }
}