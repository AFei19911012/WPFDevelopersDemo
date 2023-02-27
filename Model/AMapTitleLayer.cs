using Microsoft.Maps.MapControl.WPF;
using System;

namespace WPFDevelopersDemo.Model
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/9 23:48:48
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/9 23:48:48    CoderMan/CoderMan1012                 
    ///
    public class AMapTitleLayer : MapTileLayer
    {
        public AMapTitleLayer()
        {
            TileSource = new AMapTileSource();
        }

        public string UriFormat
        {
            get => TileSource.UriFormat;
            set => TileSource.UriFormat = value;
        }
    }
    public class AMapTileSource : TileSource
    {
        public override Uri GetUri(int x, int y, int zoomLevel)
        {
            string url = string.Format("http://wprd01.is.autonavi.com/appmaptile?x={0}&y={1}&z={2}&lang=zh_cn&size=1&scl=1&style=7", x, y, zoomLevel);
            return new Uri(url, UriKind.Absolute);
        }
    }
}