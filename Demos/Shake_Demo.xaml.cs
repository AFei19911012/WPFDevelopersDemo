using System.Windows;
using System.Windows.Controls;
using WPFDevelopers.Helpers;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// Shake_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class Shake_Demo : UserControl
    {
        public Shake_Demo()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ControlsHelper.WindowShake();
        }
    }
}