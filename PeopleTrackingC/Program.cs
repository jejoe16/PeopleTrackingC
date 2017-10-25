using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections;

namespace PeopleTrackingC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var apiInstance = new DefaultApi();


            InlineResponse2001 result = apiInstance.TurbineGet();

            var latitude = result.Latitude;
            latitude.IndexOf(0);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Map.Overview());

        }
    }
}
