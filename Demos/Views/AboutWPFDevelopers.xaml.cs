using System;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WPFDevelopersDemo.Demos.Views
{
    /// <summary>
    /// AboutWPFDevelopers.xaml 的交互逻辑
    /// </summary>
    public partial class AboutWPFDevelopers : UserControl
    {
        public AboutWPFDevelopers()
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

        private void QQHyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Uri uri = new Uri(@"https://qm.qq.com/cgi-bin/qm/qr?k=f2zl3nvoetItho8kGfe1eys0jDkqvvcL&jump_from=webapi");
            Process.Start(new ProcessStartInfo(uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}