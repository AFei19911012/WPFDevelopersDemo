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
    /// Created Time: 2023/2/8 22:35:41
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/8 22:35:41    CoderMan/CoderMan1012                 
    ///
    public class BasicControlsVM : ViewModelBase
    {
        private ObservableCollection<DemoDataModel> _DataListMode;
        public ObservableCollection<DemoDataModel> DataListMode
        {
            get => _DataListMode;
            set => Set(ref _DataListMode, value);
        }


        private bool _AllSelected;
        public bool AllSelected
        {
            get => _AllSelected;
            set
            {
                Set(ref _AllSelected, value);
                AllSelectedChanged();
            }
        }


        public BasicControlsVM()
        {
            DataListMode = new ObservableCollection<DemoDataModel>
            {
                new DemoDataModel { Date = DateTime.Now, Name = "WPFDeveloper1", Address = "China", Children = new ObservableCollection<DemoDataModel>{ new DemoDataModel { Name = "WPFDeveloper1.1" }}},
                new DemoDataModel { Date = DateTime.Now, Name = "WPFDeveloper2", Address = "China", Children = new ObservableCollection<DemoDataModel>{ new DemoDataModel { Name = "WPFDeveloper2.1" }}},
                new DemoDataModel { Date = DateTime.Now, Name = "WPFDeveloper3", Address = "China", Children = new ObservableCollection<DemoDataModel>{ new DemoDataModel { Name = "WPFDeveloper3.1" }}},
                new DemoDataModel { Date = DateTime.Now, Name = "WPFDeveloper4", Address = "China", Children = new ObservableCollection<DemoDataModel>{ new DemoDataModel { Name = "WPFDeveloper4.1" }}},
            };
        }

        private void AllSelectedChanged()
        {
            for (int i = 0; i < DataListMode.Count; i++)
            {
                DataListMode[i].IsChecked = AllSelected;
            }
        }
    }
}