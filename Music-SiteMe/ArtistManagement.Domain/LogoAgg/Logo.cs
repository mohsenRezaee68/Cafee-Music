

using _0_Framework.Domain;

namespace ArtistManagement.Domain.LogoAgg
{
    public class Logo : EntityBase
    {
        public string Picture { get; private set; }
       public string NameSite { get; private set; }

        public bool IsRemoved { get; private set; }

        public Logo(string picture, string nameSite)
        {
            Picture = picture;
            NameSite = nameSite;
            IsRemoved = false;
        }

        public void Edit(string picture, string nameSite)
        {
            Picture = picture;
            NameSite = nameSite;
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
