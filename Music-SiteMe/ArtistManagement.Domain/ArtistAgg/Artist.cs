

using _0_Framework.Domain;

namespace ArtistManagement.Domain.ArtistAgg
{
    public class Artist : EntityBase
    {
        public string Picture { get; private set; }
        public string PictureAlt { get; private set; }
        public string PictureTitle { get; private set; }
        public string Laghab { get; private set; }
        public string Text { get; private set; }
        public string Name { get; private set; }
        public string ShertText { get; private set; }
        public string Slug { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public bool IsRemoved { get; private set; }

        public Artist(string picture, string pictureAlt, string pictureTitle, 
            string laghab, string text, string name, string shertText, string slug,
            string keywords, string metaDescription)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Laghab = laghab;
            Text = text;
            Name = name;
            ShertText = shertText;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            IsRemoved = false;
        }

        public void Edit(string picture, string pictureAlt, string pictureTitle,
            string laghab, string text, string name, string shertText, string slug,
            string keywords, string metaDescription)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Laghab = laghab;
            Text = text;
            Name = name;
            ShertText = shertText;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
