using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using WPFDevelopers.Controls;
using WPFDevelopersDemo.Helpers;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// Step_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class Step_Demo : UserControl
    {
        public ObservableCollection<string> Steps
        {
            get;
            set;
        }
        public Step_Demo()
        {
            InitializeComponent();
            Steps = new ObservableCollection<string>();
            Steps.Add("Step 1");
            Steps.Add("Step 2");
            Steps.Add("Step 3");
            Steps.Add("Step 4");
            DataContext = this;
        }
        public ICommand NextCommand => new RelayCommand(new Action<object>((sender) =>
        {
            if (!(sender is UniformGrid uniformGrid))
            {
                return;
            }

            foreach (Step step in uniformGrid.Children.OfType<Step>())
            {
                step.Next();
            }
        }));
        public ICommand PreviousCommand => new RelayCommand(new Action<object>((sender) =>
        {
            if (!(sender is UniformGrid uniformGrid))
            {
                return;
            }

            foreach (Step step in uniformGrid.Children.OfType<Step>())
            {
                step.Previous();
            }
        }));
    }
}