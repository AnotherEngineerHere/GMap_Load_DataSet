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
                mapa.DragButton = MouseButtons.Left;
                mapa.CanDragMap = true;
                mapa.MapProvider = GMapProviders.OpenStreetMap;
                mapa.MinZoom = 0;
                mapa.MaxZoom = 100;
                mapa.Zoom = 9;
                mapa.AutoScroll = true;
            }
        }
    }
}
