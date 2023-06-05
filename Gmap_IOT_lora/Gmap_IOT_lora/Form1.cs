using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmap_IOT_lora
{
    public partial class Form1 : Form
    {
        GMap.NET.WindowsForms.GMapControl gmap;
        public Form1()
        {
            InitializeComponent();
            gmap = new GMap.NET.WindowsForms.GMapControl();
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            gmap.Dock = DockStyle.Fill;
            gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.ShowCenter = false;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            splitContainer1.Panel2.Controls.Add(gmap);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(37.7749, -122.4194); // Set initial position
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 13;
        }
    }
}
