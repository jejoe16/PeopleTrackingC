using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Logic.Login
{
    class Login : ILogin
    {
        Workers.User CurrentUser = null;
        bool ILogin.Login(string username, string password, Boolean isCaptain, string Location)
        {
            currentUser = new Workers.User(IsCaptain, Position, username, password);
        }
    }
}
