using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using WPFDevelopersDemo.Model;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// AMap_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class AMap_Demo : UserControl
    {
        private LocationCollection PolyLocations { get; set; }
        private MapPolyline MapPolyline { get; set; }
        private Pushpin CarPushpin { get; set; }
        private DispatcherTimer DispatcherTimer { get; set; }
        private List<Location> Locations { get; set; }
        private int Index { get; set; } = 0;

        public IEnumerable PushpinArray
        {
            get => (IEnumerable)GetValue(PushpinArrayProperty);
            set => SetValue(PushpinArrayProperty, value);
        }

        public static readonly DependencyProperty PushpinArrayProperty =
            DependencyProperty.Register("PushpinArray", typeof(IEnumerable), typeof(AMap_Demo), new PropertyMetadata(null));


        public AMap_Demo()
        {
            InitializeComponent();

            List<DemoDataModel> pushpins = new List<DemoDataModel>
            {
                new DemoDataModel { ID = 1, Location = new Location(39.8151940395589, 116.411970893135), Title = "和义东里社区" },
                new DemoDataModel { ID = 2, Location = new Location(39.9094878843105, 116.33299936282), Title = "中国水科院南小区" },
                new DemoDataModel { ID = 3, Location = new Location(39.9219204792284, 116.203500574855), Title = "石景山山姆会员超市" },
                new DemoDataModel { ID = 4, Location = new Location(39.9081417418219, 116.331244439925), Title = "茂林居小区" }
            };
            PushpinArray = pushpins;

            PolyLocations = new LocationCollection
            {
                new Location(39.9082973053021, 116.63105019548),
                new Location(31.9121578992881, 107.233555852083)
            };

            MapPolyline = new MapPolyline
            {
                Stroke = Brushes.Green,
                StrokeThickness = 2,
                Locations = PolyLocations,
            };
            CarLayer.Children.Add(MapPolyline);

            CarPushpin = new Pushpin
            {
                Template = this.Resources["CarTemplate"] as ControlTemplate,
                Location = new Location(31.9121578992881, 107.233555852083),
                PositionOrigin = PositionOrigin.Center,
            };

            CarLayer.Children.Add(CarPushpin);

            DispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1.5)
            };
            DispatcherTimer.Tick += DispatcherTimer_Tick;
        }
     
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (Index < 0)
            {
                Index = Locations.Count - 1;
                DispatcherTimer.Stop();
                return;
            }
            CarPushpin.Location = Locations[Index];
            Index--;
        }

        private void BtnCar_Click(object sender, RoutedEventArgs e)
        {
            Locations = new List<Location>
            {
                new Location(39.9082973053021, 116.63105019548),
                new Location(39.0654365763652, 115.513103745601),
                new Location(38.5861378332358, 114.897869370601),
                new Location(38.0690298850334, 114.238689683101),
                new Location(37.4436424646135, 113.491619370601),
                new Location(36.8833163124675, 112.832439683101),
                new Location(36.6015984304246, 112.480877183101),
                new Location(36.2125510101126, 112.041424058101),
                new Location(35.6074752751952, 111.426189683101),
                new Location(34.9977887035825, 110.591228745601),
                new Location(34.456028305434, 109.932049058101),
                new Location(33.9836399832877, 109.580486558101),
                new Location(33.5086116028286, 108.965252183101),
                new Location(33.1046158275268, 108.525799058101),
                new Location(32.6617655474571, 108.042400620601),
                new Location(32.179523137361, 107.515056870601),
                new Location(31.9121578992881, 107.233555852083)
            };
            Index = Locations.Count - 1;
            DispatcherTimer.Start();

        }
        private void Map_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point mousePosition = e.GetPosition(this);
            _ = map.ViewportPointToLocation(mousePosition);

            //Console.WriteLine(pinLocation);

        }

        private void Pushpin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Pushpin model = sender as Pushpin;
            map.Center = model.Location;
            map.ZoomLevel = 16;
        }

        private void PART_Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid grid = sender as Grid;
            DemoDataModel model = PushpinArray.OfType<DemoDataModel>().FirstOrDefault(x => x.ID.Equals(grid.Tag));
            map.Center = model.Location;
            map.ZoomLevel = 16;
        }
    }
}