

using _0_Framework.Application;
using Microsoft.AspNetCore.Http;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommentManagement.Application.Contracts.Contact
{
    public class CreateContact
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Etelaat { get;  set; }
       
        
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Matn { get; set; }

        public string Phone { get;  set; }
        public string Email { get;  set; }
        public string Instagram { get;  set; }
        public string Telegram { get;  set; }
        public string Watsap { get;  set; }




    }
}
