using System.Windows.Controls;
using WPFDevelopers.Controls;
using WPFDevelopersDemo.Model;
using MessageBox = WPFDevelopers.Controls.MessageBox;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// CircularMenu_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class CircularMenu_Demo : UserControl
    {
        public CircularMenu_Demo()
        {
            InitializeComponent();
        }

        private void CircularMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CircularMenu circularMenu = sender as CircularMenu;
            DemoDataModel item = circularMenu.SelectedItem as DemoDataModel;
            MessageBox.Show($"点击了{item.Title}");
        }
    }
}
