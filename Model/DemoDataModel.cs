using GalaSoft.MvvmLight;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WPFDevelopersDemo.Model
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/5 23:38:52
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/5 23:38:52    CoderMan/CoderMan1012                 
    ///
    public class DemoDataModel : ViewModelBase
    {
        public string ImgPath { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }

        private bool _IsChecked;
        public bool IsChecked
        {
            get => _IsChecked;
            set => Set(ref _IsChecked, value);
        }

        public ObservableCollection<DemoDataModel> Children { get; set; }

        // AMap
        public Location Location { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }

        // CircleMenu
        public double Angle { get; set; }
        public Brush FillColor { get; set; }
        public ImageSource IconImage { get; set; }
    }
}