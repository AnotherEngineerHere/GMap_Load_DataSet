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
using GMap_Load_DataSet.Model;

namespace GMap_Load_DataSet.GUI
{
    public partial class Map : Form
    {
        public List<Office> Of { set; get; }
        public Map()
        {

            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
         /*   GMapOverlay markers = new GMapOverlay("markers");
            mapa.DragButton = MouseButtons.Left;
            mapa.CanDragMap = true;
            mapa.MapProvider = GMapProviders.GoogleMap;
            mapa.ShowCenter = false;
            mapa.SetPositionByKeywords("Madrid, Spain");
            mapa.MinZoom = 0;
            mapa.MaxZoom = 24;
            mapa.Zoom = 9;/*
            mapa.AutoScroll = true;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;*/
            Loadtable();
            
        }

        private void Loadtable()
        { 
           
            listMap2.Columns.Add("", "MUNICIPIO");
            listMap2.Columns.Add("", "TELEFONO");
            listMap2.Columns.Add("", "EMAIL");
            listMap2.Columns.Add("", "DIRECCIÓN");
            listMap2.Columns.Add("", "HORARIO");
            listMap2.Columns.Add("", "DEPARTAMENTO");
            listMap2.Columns.Add("", "CODIGO POSTAL");
            for (int i = 0; i < Of.Count; i++)
            {
                listMap2.Rows.Add(Of[i].Ubication, Of[i].Phone, Of[i].Email, Of[i].Address,
                    Of[i].Schedule, Of[i].Departament, Of[i].Postal_Code);
            }
        }

        private void listMap2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
