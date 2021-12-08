using _01_LampshadeQuery.Contracts.Comment;
using System;
using System.Collections.Generic;

namespace _01_LampshadeQuery.Contracts.Account
{
    public class UserMusicQueryModel
    {
         public string Name { get;  set; }
         public long Id { get;  set; }
        public string Singer { get;  set; }
        public string UserName { get; set; }
        public string Photo { get; set; }
        public string Sabk { get;  set; }
        public string Slug { get;  set; }
        public string Keywords { get;  set; }
  
        public string Track { get; set; }
        public bool IsConfirmed { get;  set; }
        public bool IsCanceled { get;  set; }
        public string PublishDate { get;  set; }
        public AccountQueryModel Account { get; set; }
    }

}