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
        private Map.IMap map = new Map.MapControl();
        public Controller()
        {
            DownloadTurbines();
            SetWindTurbineMarkers();


        }

        /// <summary>
        /// downloads the list of turbines from the server and adds them to the client 
        /// </summary>
        private void DownloadTurbines()
        {
            var apiInstance = new DefaultApi();
            InlineResponse2001 result = apiInstance.TurbineGet();

            //List<long> latitude = new List<long>();
            //List<long> longitude = new List<long>();
            //List<String> name = new List<String>();

            //name.Add("A1");
            //latitude.Add(56572061873);
            //longitude.Add(11309738159);


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
            map.SetTurbineMarkers(turbinelist);
        }


    }
}
