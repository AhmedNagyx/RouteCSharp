using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string User, string Pass);
        bool AuthorizeUser(string User, string Role);
    }
}
