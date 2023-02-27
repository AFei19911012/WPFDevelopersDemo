using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFDevelopers.Controls;
using WPFDevelopersDemo.ViewModel;
using MessageBox = WPFDevelopers.Controls.MessageBox;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// BasicControls_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class BasicControls_Demo : UserControl
    {
        public static readonly DependencyProperty AllSelectedProperty =
            DependencyProperty.Register("AllSelected", typeof(bool), typeof(BasicControls_Demo),
                new PropertyMetadata(AllSelectedChangedCallback));

        private static void AllSelectedChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((d as BasicControls_Demo).DataContext as BasicControlsVM).AllSelected = (bool)e.NewValue;
        }

        public bool AllSelected
        {
            get => (bool)GetValue(AllSelectedProperty);
            set => SetValue(AllSelectedProperty, value);
        }

        public BasicControls_Demo()
        {
            InitializeComponent();
        }

        private void Loading_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(() => { Thread.Sleep(3000); });
            task.ContinueWith(previousTask => { Loading.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
            Loading.Show();
            task.Start();
        }

        private void LoadingOff_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(() => { Thread.Sleep(3000); });
            task.ContinueWith(previousTask => { Loading.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
            Loading.Show(true);
            task.Start();
        }

        private void LoadingOffTask_Click(object sender, RoutedEventArgs e)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = tokenSource.Token;

            Task task = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    // 这里做自己的事情
                    if (tokenSource.IsCancellationRequested)
                    {
                        return;
                    }

                    Thread.Sleep(1000);
                }
            }, cancellationToken);
            _ = task.ContinueWith(previousTask =>
              {
                  if (tokenSource.IsCancellationRequested)
                  {
                      return;
                  }

                  Loading.Close();
              }, TaskScheduler.FromCurrentSynchronizationContext());
            Loading.Show(true);
            Loading.LoadingQuitEvent += delegate
            {
                tokenSource.Cancel();
            };
            task.Start();
        }

        private void BtnLoading_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(() => { Thread.Sleep(3000); });
            task.ContinueWith(previousTask => { Loading.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
            Loading.Show(btnLoading, 18.0d, Brushes.White);
            task.Start();
        }

        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("文件删除成功。", "消息", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnWarning_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("当前文件不存在！", "警告", MessageBoxImage.Warning);
        }

        private void btnError_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("当前文件不存在。", "错误", MessageBoxImage.Error);
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("当前文件不存在,是否继续?", "询问", MessageBoxButton.OKCancel, MessageBoxImage.Question);
        }
    }
}