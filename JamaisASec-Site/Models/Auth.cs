using JamaisASec_Site.Components.Account.Pages.Manage;

namespace JamaisASec_Site.Models
{
    public class Auth
    {
        public string email { get; set; }
        public string password { get; set; }

        public Client? client { get; set; }
        public string? error { get; set; }

    }
}
