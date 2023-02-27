using GalaSoft.MvvmLight;
using System;
using System.Collections.ObjectModel;
using WPFDevelopersDemo.Model;

namespace WPFDevelopersDemo.ViewModel
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/5 22:57:42
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/5 22:57:42    CoderMan/CoderMan1012                 
    ///
    public class MainWindowVM : ViewModelBase
    {
        private ObservableCollection<DemoDataModel> _DataList;
        public ObservableCollection<DemoDataModel> DataList
        {
            get => _DataList;
            set => Set(ref _DataList, value);
        }

        public MainWindowVM()
        {
            GetDataList();
        }

        private void GetDataList()
        {
            DataList = new ObservableCollection<DemoDataModel>();
            foreach (object item in Enum.GetValues(typeof(EnumMenu)))
            {
                string icon = item.ToString().Substring(0, 1);
                DataList.Add(new DemoDataModel { ImgPath = string.Format("pack://application:,,,/Resource/Image/LeftMainContent/{0}.png", icon), Name = item.ToString() });
            }
        }
    }
}