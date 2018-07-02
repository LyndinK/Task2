using BingMapsRESTToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APITryout
{
    public partial class Form1 : Form
    {
        public List<SimpleWaypoint> path = new List<SimpleWaypoint>();
        public List<double> latitudes = new List<double>();
        public List<double> longtitudes = new List<double>();
        public List<ImageryPushpin> pushpins = new List<ImageryPushpin>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
        }

        private async void ADD_button_ClickAsync(object sender, EventArgs e)
        {
            if (querybox.Text != String.Empty)
            {
                //получение координат введённой точки
                var request = new GeocodeRequest()
                {
                    Query = querybox.Text,
                    IncludeIso2 = true,
                    IncludeNeighborhood = true,
                    MaxResults = 25,
                    BingMapsKey = "AvNYCSU2MmF9vSmTbV_ha_WPAxMroM9r_efIFraDGMZZPqWNjS5Xm7sb_qaVuEJc"
                };
                var response = await ServiceManager.GetResponseAsync(request);

                if (response != null &&
                    response.ResourceSets != null &&
                    response.ResourceSets.Length > 0 &&
                    response.ResourceSets[0].Resources != null &&
                    response.ResourceSets[0].Resources.Length > 0)
                {
                    var longt = (response.ResourceSets[0].Resources[0] as Location).GeocodePoints[0].Coordinates[1];
                    var lat = (response.ResourceSets[0].Resources[0] as Location).GeocodePoints[0].Coordinates[0];
                    path.Add(new SimpleWaypoint(lat, longt));
                    latitudes.Add(lat);
                    longtitudes.Add(longt);
                    pushpins.Add(new ImageryPushpin {
                        Location = new Coordinate(lat,longt)
                    });
                    inserted.Text += Convert.ToString(lat) + " " + Convert.ToString(longt) + "\n";
                    querybox.Text = "";                }
            }
        }

        private async void GO_button_Click(object sender, EventArgs e)
        {
            if (path.Count>=2 && path.Count <= 4)
            {
                RouteInfo.Text = "";
                //построение маршрута по введённым точкам
                var GO = new RouteRequest()
                {
                    RouteOptions = new RouteOptions()
                    {
                        RouteAttributes = new List<RouteAttributeType>()
                            {
                                  RouteAttributeType.RoutePath
                            }
                    },
                    Waypoints = path,
                    BingMapsKey = "AvNYCSU2MmF9vSmTbV_ha_WPAxMroM9r_efIFraDGMZZPqWNjS5Xm7sb_qaVuEJc"
                };
                var response = await ServiceManager.GetResponseAsync(GO);

                if (response != null &&
                    response.ResourceSets != null &&
                    response.ResourceSets.Length > 0 &&
                    response.ResourceSets[0].Resources != null &&
                    response.ResourceSets[0].Resources.Length > 0)
                {

                    RouteInfo.Text+= "общее расстояние (км): "+(response.ResourceSets[0].Resources[0] as Route).TravelDistance.ToString()+"\n";
                    RouteInfo.Text += "время в пути (часы): "+Convert.ToString((int)(response.ResourceSets[0].Resources[0] as Route).TravelDuration/360) + "\n";
                }
                var imagereq = new ImageryRequest()
                {
                    //получение статического изображения маршрута
                    ImagerySet = ImageryType.RoadOnDemand,
                    BingMapsKey = "AvNYCSU2MmF9vSmTbV_ha_WPAxMroM9r_efIFraDGMZZPqWNjS5Xm7sb_qaVuEJc",
                    ZoomLevel = 10,
                    MapArea = new BoundingBox
                    {
                        EastLongitude = longtitudes.Max(),
                        WestLongitude = longtitudes.Min(),
                        NorthLatitude = latitudes.Max(),
                        SouthLatitude = latitudes.Min(),
                    },
                    Pushpins = pushpins,
                    HighlightEntity = true


                };
                using (var imageStream = await ServiceManager.GetImageAsync(imagereq))
                {
                    Image img = Image.FromStream(imageStream);
                    MapBox.Image = img;
                    MapBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                MessageBox.Show("задайте от двух до четырёх точек маршрута");
            }
        }

    }
}
