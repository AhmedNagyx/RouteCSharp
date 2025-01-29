using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_.Classes
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private string _username="Ahmed";
        private string _pass="1234";
        private string _role="Admin";
        public bool AuthenticateUser(string User, string Pass)
        {
            return (User == _username) && (Pass == _pass);
        }

        public bool AuthorizeUser(string User, string Role)
        {
            return (User == _username) && (Role == _role);
        }
    }
}
