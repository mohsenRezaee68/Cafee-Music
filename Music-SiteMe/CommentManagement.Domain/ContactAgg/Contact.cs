


using _0_Framework.Domain;

namespace CommentManagement.Domain.ContactAgg
{
    public class Contact : EntityBase
    {
        public string Etelaat { get; private set; }
        
        public string Matn { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Instagram { get; private set; }
        public string Telegram { get; private set; }
        public string Watsap { get; private set; }
       
        public bool IsRemoved { get; private set; }

        public Contact(string etelaat, string matn, string phone, string email,
            string instagram, string telegram, string watsap)
        {
            Etelaat = etelaat;
            Matn = matn;
            Phone = phone;
            Email = email;
            Instagram = instagram;
            Telegram = telegram;
            Watsap = watsap;
            IsRemoved = false;
        }

        public void Edite(string etelaat, string matn, string phone, string email,
            string instagram, string telegram, string watsap)
        {
            Etelaat = etelaat;
            Matn = matn;
            Phone = phone;
            Email = email;
            Instagram = instagram;
            Telegram = telegram;
            Watsap = watsap;
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
