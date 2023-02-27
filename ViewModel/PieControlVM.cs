using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFDevelopers.Controls;

namespace WPFDevelopersDemo.ViewModel
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/11 17:07:13
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/11 17:07:13    CoderMan/CoderMan1012                 
    ///
    public class PieControlVM : ViewModelBase
    {
        private ObservableCollection<PieSegmentModel> _PieSegmentModels;
        public ObservableCollection<PieSegmentModel> PieSegmentModels
        {
            get => _PieSegmentModels;
            set => Set(ref _PieSegmentModels, value);
        }

        public RelayCommand CmdRefresh => new Lazy<RelayCommand>(() => new RelayCommand(Refresh)).Value;
        private void Refresh()
        {
            IsRefresh = !IsRefresh;
            PieSegmentModels = IsRefresh ? CollectionList[1] : CollectionList[0];
        }

        private List<ObservableCollection<PieSegmentModel>> CollectionList { get; set; } = new List<ObservableCollection<PieSegmentModel>>();
        private bool IsRefresh { get; set; } = false;

        public PieControlVM()
        {
            ObservableCollection<PieSegmentModel> collection1 = new ObservableCollection<PieSegmentModel>
            {
                new PieSegmentModel { Name = "一", Value = 10 },
                new PieSegmentModel { Name = "二", Value = 20 },
                new PieSegmentModel { Name = "三", Value = 25 },
                new PieSegmentModel { Name = "四", Value = 45 }
            };

            ObservableCollection<PieSegmentModel> collection2 = new ObservableCollection<PieSegmentModel>
            {
                new PieSegmentModel { Name = "一", Value = 30 },
                new PieSegmentModel { Name = "二", Value = 15 },
                new PieSegmentModel { Name = "三", Value = 10 },
                new PieSegmentModel { Name = "四", Value = 55 }
            };
            CollectionList.AddRange(new[] { collection1, collection2 });

            PieSegmentModels = CollectionList[0];
        }
    }
}