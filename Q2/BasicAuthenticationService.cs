using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        string [] users;
        string[] password;

        public bool AuthenticateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool AuthorizeUser(string username, string role)
        {
            throw new NotImplementedException();
        }
    }
}
