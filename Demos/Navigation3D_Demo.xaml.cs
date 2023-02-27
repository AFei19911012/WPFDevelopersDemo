using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// Navigation3D_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class Navigation3D_Demo : UserControl
    {
        public Navigation3D_Demo()
        {
            InitializeComponent();
        }

        private void GithubHyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void GiteeHyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}