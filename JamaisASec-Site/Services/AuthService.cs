using JamaisASec_Site.Models;


namespace JamaisASec_Site.Services
{
    public class AuthService
    {
        private bool IsLoggedIn { get; set; }
        private Client? LoggedUser { get; set; }


        public AuthService()
        {
            IsLoggedIn = false;
            LoggedUser = null;
        }

        public void Logout()
        {
            LoggedUser = null;
            IsLoggedIn = false;
        }

        public void Login(Client client)
        {
            IsLoggedIn = true;
            LoggedUser = client;
        }

        public bool AuthCheck() { return IsLoggedIn; }
        public Client getUser() { return LoggedUser; }


    }
}
