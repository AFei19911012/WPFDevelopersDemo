using System.Windows;
using WPFDevelopers.Helpers;

namespace WPFDevelopersDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static double Wdith => SystemParameters.WorkArea.Width / 1.5;
        public static double Height => SystemParameters.WorkArea.Height / 1.5;
        public static Window CurrentMainWindow => Current.MainWindow;
        public static ThemeType Theme { get; set; }
    }
}