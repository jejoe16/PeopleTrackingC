using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Position
{
    class TurbinePosition : ITurbinePosition
    {
        private int radius = 100;
        private ArrayList windturbines = new ArrayList();
        private VesselPosition vessel = new VesselPosition();


        public void AddTurbine(string name, int latitude,int longitude)
        {
            WindTurbine wt;
            windturbines.Add(wt = new WindTurbine(name,latitude, longitude));
        }

        public string GetWindTurbine()
        {
            foreach (WindTurbine wts in windturbines)
            {
                int lat = vessel.GetLatitude(); // vessel lat 
                int lon = vessel.GetLongitude(); // vessel long
                double result = (Math.Pow((lat - wts.GetLatitude()), 2) + Math.Pow((lon - wts.GetLongitude()), 2));

                if (result <= Math.Pow(radius, 2))
                {
                    return wts.GetName();
                }
            }
            return null;


        }
    }
}
