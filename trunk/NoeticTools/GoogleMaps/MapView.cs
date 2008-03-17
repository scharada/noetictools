using System;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.GoogleMaps
{
	public partial class MapView : DockContent
	{
		public MapView()
		{
			InitializeComponent();
		}

		private void MapView_Load(object sender, System.EventArgs e)
		{
		}

		private void webBrowser_Resize(object sender, EventArgs e)
		{
			string url =
				string.Format(
					@"http://www.google.com/mapdata?Point=b&Point.latitude_e6=39106470&Point.longitude_e6=4210462536&Point.iconid=4294967295&Point=e&latitude_e6=-38266667&longitude_e6=146550000&zm=50000&w={0}&h={1}&cc=US&min_priority=1",
					Size.Width-20, Size.Height-30);

			Uri uri = new Uri(url);
			webBrowser.Url = uri;
		}

		//			/*
		//=GoogleMap.vb== http://www.experts-exchange.com/Programming/Languages/.NET/Visual_Basic.NET/Q_22667318.html

		//public class GoogleMap
		//{
		//    private string Location;
		//    //' A regex to extract the lat and long from KML.
		//    private readonly Regex coordinatesRegex = new Regex("<coordinates>(?<longitude>[^,]*),(?<latitude>[^,]*)");

		//    public void MoveTo(string location)
		//    {
		//        WebClient webClient = new WebClient();
		//        string source =
		//            webClient.DownloadString("http://maps.google.com/maps?output=kml&q=" + Uri.EscapeUriString(location));

		//        Match match = coordinatesRegex.Match(source);

		//        Location LookAt = new Location(match.Groups("longitude").Value, match.Groups("latitude").Value)
		//        UpdateBackgroundImage(LookAt, size)
		//    }

		//    public void UpdateBackgroundImage(Location lookAt, Size size)
		//    {
		//        //http://www.google.com/mapdata?Point=b&Point.latitude_e6=39106470&Point.longitude_e6=4210462536&Point.iconid=4294967295&Point=e&latitude_e6=39106470&longitude_e6=4210462536&zm=19200&w=120&h=80&cc=US&min_priority=1
		//        WebClient webClient = new WebClient();
		//        BackgroundImage =
		//            Image.FromStream(
		//                webClient.OpenRead(
		//                    String.Format(
		//                        "http://maps.google.com/mapdata?latitude_e{0}={1}&longitude_e{2}={3}&zm=9600&w={4}&h={5}&cc=&min_priority=2",
		//                        lookAt.LatitudeDp, lookAt.Latitude, lookAt.LongitudeDp, lookAt.Longitude, size.Width, size.Height)))
		//    }

		//    private void ResizeMap(Object sender, EventArgs e)
		//    {
		//        UpdateBackgroundImage(LookAt, Size);
		//    }
		//}

		//public class Location
		//{
		//    private int _longitudeDp;
		//    private int _latitudeDp;
		//    private int _longitude;
		//    private int _latitude;

		//    public int LongitudeDp
		//    {
		//        get { return _longitudeDp; }
		//        set { _longitudeDp = value; }
		//    }

		//    public int LatitudeDp
		//    {
		//        get { return _latitudeDp; }
		//        set { _latitudeDp = value; }
		//    }

		//    public int Longitude
		//    {
		//        get { return _longitude; }
		//        set { _longitude = value; }
		//    }

		//    public int Latitude
		//    {
		//        get { return _latitude; }
		//        set { _latitude = value; }
		//    }

		//    public void New(string longitudeString, string latitudeString)
		//    {
		//        LongitudeDp = longitudeString.Length - longitudeString.IndexOf(".") - 1;
		//        LatitudeDp = latitudeString.Length - latitudeString.IndexOf(".") - 1;

		//        longitudeString = longitudeString.Replace(".", "");
		//        latitudeString = latitudeString.Replace(".", "");

		//        Longitude = int.Parse(longitudeString);
		//        Latitude = int.Parse(latitudeString);
		//    }
		//}
	}
}