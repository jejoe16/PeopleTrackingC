using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Persistence.API
{
    class APIController : IAPIController
    {   
        private static APIController apicontroller = null;
        private DefaultApi api = null;
        private InlineResponse200 response200 = null;
        private InlineResponse2001 response2001 = null;

        APIController()
        {
            api = new DefaultApi();
        }

        public static APIController GetAPIController()
        {
            if (apicontroller == null)
            {
                apicontroller = new APIController();
            }
            return apicontroller;
        }

        public bool CaptainCheck()
        {
            throw new NotImplementedException();
        }

        public ArrayList GetTurbinesName()
        {
            throw new NotImplementedException();
        }

        public ArrayList GetTurbinesLongitude()
        {
            throw new NotImplementedException();
        }

        public ArrayList GetTurbinesLatitude()
        {
            throw new NotImplementedException();
        }

        public long GetUserLatitude()
        {
            throw new NotImplementedException();
        }

        public long GetUserLongitude()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public string GetUserPassWord()
        {
            throw new NotImplementedException();
        }

        public void Login(string Username, string Password)
        {
            response200 = api.GetUserUsernamePasswordGet(Username, Password);
        }
    }
}
