using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using WPFDevelopersDemo.Model;

namespace WPFDevelopersDemo.ViewModel
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/10 23:45:43
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/10 23:45:43    CoderMan/CoderMan1012                 
    ///
    public class CircularMenuVM : ViewModelBase
    {
        private ObservableCollection<DemoDataModel> _ListMenuItems;
        public ObservableCollection<DemoDataModel> ListMenuItems
        {
            get => _ListMenuItems;
            set => Set(ref _ListMenuItems, value);
        }

        public CircularMenuVM()
        {
            int angle = 0;
            ListMenuItems = new ObservableCollection<DemoDataModel>();
            for (int i = 1; i <= 8; i++)
            {
                ListMenuItems.Add(new DemoDataModel
                {
                    Angle = angle,
                    Title = $"菜单{i}",
                    IconImage = new BitmapImage(new Uri($"pack://application:,,,/Resource/Image/CircularMenu/{i}.png")),
                });
                angle += 45;
            }
        }
    }
}