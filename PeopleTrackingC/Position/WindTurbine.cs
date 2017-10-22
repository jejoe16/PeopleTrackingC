using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Position
{
    

    class WindTurbine
    {
        private int latitude;
        private int longitude;
        private string name;
        /// <summary>
        /// Constructor that create an object of a wind turbine
        /// </summary>
        /// <param name="latitude">the latitude of the wind turbines position</param>
        /// <param name="longitude">the longitude of the wind turbines position</param>
        public WindTurbine(string name, int latitude, int longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.name = name;
        }

        public int GetLatitude()
        {
            return latitude;
        }

        public int GetLongitude()
        {
            return longitude;
        }

        public string GetName()
        {
            return name;
        }
    }
}
