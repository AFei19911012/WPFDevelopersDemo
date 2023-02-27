using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDevelopersDemo.ViewModel
{
    ///
    /// ----------------------------------------------------------------
    /// Copyright @CoderMan/CoderMan1012 2023 All rights reserved
    /// Author      : CoderMan/CoderMan1012
    /// Created Time: 2023/2/11 23:48:51
    /// Description :
    /// ------------------------------------------------------
    /// Version      Modified Time              Modified By                               Modified Content
    /// V1.0.0.0     2023/2/11 23:48:51    CoderMan/CoderMan1012                 
    ///
    public class PaginationVM : ViewModelBase
    {
        private ObservableCollection<int> _ListPagination = new ObservableCollection<int>();
        public ObservableCollection<int> ListPagination
        {
            get => _ListPagination;
            set => Set(ref _ListPagination, value);
        }

        private int _Count = 300;
        public int Count
        {
            get => _Count;
            set
            {
                _ = Set(ref _Count, value);
                CurrentPageChanged();
            }
        }

        private int _CountPerPage = 10;
        public int CountPerPage
        {
            get => _CountPerPage;
            set
            {
                _ = Set(ref _CountPerPage, value);
                CurrentPageChanged();
            }
        }

        private int _Current = 1;
        public int Current
        {
            get => _Current;
            set
            {
                _ = Set(ref _Current, value);
                CurrentPageChanged();
            }
        }


        private List<int> SourceList { get; set; } = new List<int>();

        public PaginationVM()
        {
            SourceList.AddRange(Enumerable.Range(1, 300));

            CurrentPageChanged();
        }

        private void CurrentPageChanged()
        {
            ListPagination.Clear();

            foreach (int i in SourceList.Skip((Current - 1) * CountPerPage).Take(CountPerPage))
            {
                ListPagination.Add(i);
            }
        }
    }
}