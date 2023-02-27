using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using WPFDevelopersDemo.Helpers;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// DrawerMenu_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class DrawerMenu_Demo : UserControl
    {
        private List<Uri> _uriList = new List<Uri>()
        {
            new Uri("../Demos/Pages/HomePage.xaml",UriKind.Relative),
            new Uri("../Demos/Pages/EdgePage.xaml",UriKind.Relative),
        };
        public DrawerMenu_Demo()
        {
            InitializeComponent();
            myFrame.Navigate(_uriList[0]);
        }

        public ICommand HomeCommand => new RelayCommand(obj =>
        {
            myFrame.Navigate(_uriList[0]);
        });
        public ICommand EdgeCommand => new RelayCommand(obj =>
        {
            myFrame.Navigate(_uriList[1]);
        });
        public ICommand CloudCommand => new RelayCommand(obj =>
        {
            WPFDevelopers.Controls.MessageBox.Show("点击了云盘", "提示");
        });
        public ICommand MailCommand => new RelayCommand(obj =>
        {
            WPFDevelopers.Controls.MessageBox.Show("点击了邮件", "提示");
        });
        public ICommand VideoCommand => new RelayCommand(obj =>
        {
            WPFDevelopers.Controls.MessageBox.Show("点击了视频", "提示");
        });
    }
}
