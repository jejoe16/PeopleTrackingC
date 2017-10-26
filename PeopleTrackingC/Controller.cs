using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC
{
    class Controller
    {
        private Position.ITurbinePosition turbines = new Position.TurbinePosition();
        public Controller()
        {
          //  DownloadTurbines();
         //   SetWindTurbineMarkers();
        }

        /// <summary>
        /// downloads the list of turbines from the server and adds them to the client 
        /// </summary>
        private void DownloadTurbines()
        {
            var apiInstance = new DefaultApi();
            InlineResponse2001 result = apiInstance.TurbineGet();

            var latitude = result.Latitude;
            var longitude = result.Longtitude;
            var name = result.Name;

        for (int i = 0; i < name.Count; i++)
            {
                turbines.AddTurbine(name[i], (long)latitude[i], (long)longitude[i]);
            }
        }
        
        private void SetWindTurbineMarkers()
        {
            var turbinelist = turbines.GetTurbineList();

        }


    }
}
