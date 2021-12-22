using _01_LampshadeQuery.Contracts.Account;
using _01_LampshadeQuery.Contracts.Article;
using _01_LampshadeQuery.Contracts.Artist;
using _01_LampshadeQuery.Contracts.Music;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Newtonsoft.Json;

using System.Collections.Generic;


namespace ServiceHost.Areas.Admin.Pages
{
    [Authorize(Roles = "1 , 2")]
    public class IndexModel : PageModel
    {
        public int albom { get; set; }
        public Chart DoughnutDataSet { get; set; }
        public Chart polarAreaDataSet { get; set; }
        public List<Chart> BarLineDataSet { get; set; }
        public List<AccountAll> TotalUsers { get; set; }
        public List<AccountAll> ActivUser { get; set; }
        public List<AccountAll> RemoveUsers { get; set; }
        public List<UserMusicQueryModel> UserMusic { get; set; }
        public List<MusicQueryModel> ArshivMusic { get; set; }
        public List<MusicQueryModel> AlbomMusics{get;set;}
        public List<ArticleQueryModel> Avent { get; set; }
        public List<ArticleQueryModel> Article { get; set; }
        public List<MusicQueryModel> GetAllTracksMazhabi { get; set; }
        public List<MusicQueryModel> ArshivIrani { get; set; }
        public List<MusicQueryModel> ArshivAfg { get; set; }
        public List<MusicQueryModel> ArshivMenal { get; set; }
        public List<ArtistQueryModel> LatestArtistAlls { get; set; }
        public List<UserMusicQueryModel> UserMusicAll{ get; set; }
        private readonly IAccountQuery _accountQuery;
        private readonly IMusicQuery _musicQuery;
        private readonly IArticleQuery _articleQuery; 
             private readonly IArtistQuery _artistQuery;
        public IndexModel(IAccountQuery accountQuery , IMusicQuery musicQuery, IArticleQuery articleQuery, IArtistQuery artistQuery)
        {
            _artistQuery = artistQuery;
            _articleQuery = articleQuery;
            _musicQuery = musicQuery;
            _accountQuery = accountQuery;
        }
        public void OnGet()
        {
            TotalUsers = _accountQuery.accountAlls();
            ActivUser = _accountQuery.UsersActive();
            RemoveUsers = _accountQuery.RemoveUsers();
            UserMusic = _accountQuery.UserMusic();
            AlbomMusics = _musicQuery.GetAlbomMusics();
            ArshivMusic = _musicQuery.ArshivMusic();
             albom = AlbomMusics.Count;
            Avent = _articleQuery.LatestAventAlls();
            Article = _articleQuery.LatestArticleAlls();
            GetAllTracksMazhabi = _musicQuery.GetAllTracksMazhabi();
            ArshivIrani = _musicQuery.ArshivIrani();
            ArshivAfg = _musicQuery.ArshivAfg();
            ArshivMenal = _musicQuery.ArshivMenal();
            LatestArtistAlls = _artistQuery.LatestArtistAlls();

            BarLineDataSet = new List<Chart>
            {
                new Chart
                {
                    Label = "آلبوم",
                    Data = new List<int> {albom},
                    BackgroundColor = new[] {"#000000"},
                    BorderColor = "#b5838d"
                },
                  new Chart
                {
                    Label = "تک آهنگ",
                    Data = new List<int> { ArshivMusic.Count},
                    BackgroundColor = new[] {"#FF0000"},
                    BorderColor = "#ffafcc"
                },
                new Chart
                {
                    Label = "آهنگ کاربران",
                    Data = new List<int> {UserMusic.Count},
                    BackgroundColor = new[] {"#32CD32"},
                    BorderColor = "#7FFF00"
                },

              };

            DoughnutDataSet = new Chart
            {
                Label = "Apple",
                Data = new List<int> { GetAllTracksMazhabi.Count, ArshivIrani.Count, ArshivAfg.Count, ArshivMenal.Count,Avent.Count,Article.Count, LatestArtistAlls .Count,UserMusic.Count},
                BorderColor = "#ffcdb2",
                BackgroundColor = new[] { "#000000", "#ffd166", "#7f4f24", "#ef233c" , "#00FFFF" , "#7FFF00" , "#FF1493" ,"#FF1493"}
            };

           
        }
    }

    public class Chart
    {
        [JsonProperty(PropertyName = "label")] public string Label { get; set; }

        [JsonProperty(PropertyName = "data")] public List<int> Data { get; set; }

        [JsonProperty(PropertyName = "backgroundColor")]
        public string[] BackgroundColor { get; set; }

        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }
    }
}
