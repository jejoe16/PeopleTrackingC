using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleTrackingC.Map
{
    public partial class Overview : Form
    {
        GMap.NET.WindowsForms.GMapMarker marker;
        GMap.NET.WindowsForms.GMapMarker marker1;
        GMap.NET.WindowsForms.GMapOverlay markers;
        public Overview()
        {
            InitializeComponent();
        }

        private void Onload(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.OpenStreet4UMapProvider.Instance;


            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("anholt");
            gmap.MinZoom = 0;
            gmap.MaxZoom = 50;
            gmap.Zoom = 10;

// ads marker
            Bitmap bit = new Bitmap(PeopleTrackingC.Properties.Resources.vessel);
            Bitmap resized = new Bitmap(bit, new Size(20, 40));

            GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(56.716882, 11.549656), new Bitmap(resized));


            Bitmap bit1 = new Bitmap(PeopleTrackingC.Properties.Resources.wind);
            Bitmap resized1 = new Bitmap(bit1, new Size(20, 40));

            GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(56.616882, 11.449656), new Bitmap(resized1));



            gmap.Overlays.Add(markersOverlay);

            markersOverlay.Markers.Add(marker);
            markersOverlay.Markers.Add(marker1);

            //markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

        }

        private void MouseClickE(object sender, EventArgs e)
        {


        }
    }
}
