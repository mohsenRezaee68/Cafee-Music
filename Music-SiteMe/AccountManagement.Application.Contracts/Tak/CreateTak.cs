


using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Tak
{
    public class CreateTak
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Singer { get; set; }

        public IFormFile Trak { get; set; }
        
        public string Sabk { get; set; }

        public long UserId { get; set; }

         public string Slug { get; set; }
        public DateTime PublishDate { get; set; }

        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public List<AccountViewModel> accounts { get; set; }
       
       
       
    }
}
