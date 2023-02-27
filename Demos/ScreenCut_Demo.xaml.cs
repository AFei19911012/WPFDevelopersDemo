using System;
using System.Windows;
using System.Windows.Controls;
using WPFDevelopers.Controls.ScreenCapturer;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// ScreenCut_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class ScreenCut_Demo : UserControl
    {
        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(ScreenCut_Demo), new PropertyMetadata(false));

        public ScreenCut_Demo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Dispatcher.Invoke(new Action(delegate
            {
                ScreenCapture screenCapturer;
                if (IsChecked)
                {
                    App.CurrentMainWindow.WindowState = WindowState.Minimized;
                    //Thread.Sleep(1000);
                }
                screenCapturer = new ScreenCapture();
                screenCapturer.SnapCompleted += ScreenCapturer_SnapCompleted;
                screenCapturer.SnapCanceled += ScreenCapturer_SnapCanceled;
                screenCapturer.Capture();
            }));

        }

        private void ScreenCapturer_SnapCanceled()
        {
            App.CurrentMainWindow.WindowState = WindowState.Normal;
        }

        private void ScreenCapturer_SnapCompleted(System.Windows.Media.Imaging.CroppedBitmap bitmap)
        {
            App.CurrentMainWindow.WindowState = WindowState.Normal;
        }
    }
}