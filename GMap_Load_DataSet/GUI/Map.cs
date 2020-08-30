using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


namespace GMap_Load_DataSet.GUI
{
    public partial class Map : Form
    {
        GMapOverlay overlayOne;
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            {
                gmap.MapProvider = GMapProviders.GoogleMap;
                gmap.MinZoom = 3;
                gmap.MaxZoom = 17;
                gmap.Zoom = 17;
                gmap.CanDragMap = true;
                gmap.Manager.Mode = AccessMode.ServerAndCache;
                overlayOne = new GMapOverlay(gmap, "OverlayOne");
                lsMarcas.Add("-16.438389, -71.528358");
                lsMarcas.Add("-16.438606, -71.527878");
                lsMarcas.Add("-16.438465, -71.527824");
                lsMarcas.Add("-16.437904, -71.527580");
                gmap.Position = new PointLatLng(-16.438389, -71.528358);
                foreach (string cad in lsMarcas)
                {
                    Double lat, lon;
                    string[] aCad = cad.Split(',');
                    lat = Convert.ToDouble(aCad[0]);
                    lon = Convert.ToDouble(aCad[1]);
                    overlayOne.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new PointLatLng(lat, lon)));
                    gmap.Overlays.Add(overlayOne);
                }
            }
        }
    }
}
