

using _0_Framework.Domain;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.RoleAgg;
using System;

namespace AccountManagement.Domain.TakAgg
{
    public class Tak : EntityBase
    {
       
        public string Track { get; private set; }
        
        public string TrackName { get; private set; }
        public string TrackSinger { get; private set; }
        public bool IsConfirmed { get; private set; }
        public bool IsCanceled { get; private set; }
        public DateTime PublishDate { get; private set; }
        public string Sabk { get; private set; }
        public Account account { get; private set; }
        public Role role { get; private set; }
        public long UserId { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }

        public Tak(string track, string trackName, string trackSinger, DateTime publishDate,
            string sabk, long userId, string slug, string keywords, string metaDescription)
        {
            Track = track;
            TrackName = trackName;
            TrackSinger = trackSinger;
            PublishDate = publishDate;
            Sabk = sabk;
            UserId = userId;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }

        public void Edit( string trackName, string trackSinger,
            string sabk,  string slug, string keywords, string metaDescription)
        {
            
            TrackName = trackName;
            TrackSinger = trackSinger;
           
            Sabk = sabk;
           
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
        }

        public void Confirm()
        {
            IsConfirmed = true;
        }

        public void Cancel()
        {
            IsCanceled = true;
        }
    }
}
