using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Persistence.API
{
    interface IAPIController
    {
        ArrayList GetTurbinesName();
        ArrayList GetTurbinesLongitude();
        ArrayList GetTurbinesLatitude();
        void Login(String UserName, String PassWord);
        long GetUserLatitude();
        long GetUserLongitude();
        String GetUserName();
        String GetUserPassWord();
        Boolean CaptainCheck();
    }
}
