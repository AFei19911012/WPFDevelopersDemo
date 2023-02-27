using HandyControl.Tools.Extension;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using WPFDevelopers;
using WPFDevelopers.Controls;
using WPFDevelopersDemo.Demos;
using WPFDevelopersDemo.Demos.Windows;
using WPFDevelopersDemo.Model;
using WPFDevelopersDemo.ViewModel;
using MessageBox = WPFDevelopers.Controls.MessageBox;

namespace WPFDevelopersDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        private MainWindowVM VM { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            VM = DataContext as MainWindowVM;

            xamlCode.Load(@"..\Demos\Views\AboutWPFDevelopers.xaml");
            csCode.Load(@"..\Demos\Views\AboutWPFDevelopers.xaml.cs");
        }

        private void SearchBar_OnSearchStarted(object sender, HandyControl.Data.FunctionEventArgs<string> e)
        {
            string key = e.Info;
            if (!(sender is FrameworkElement searchBar && searchBar.Tag is ListBox listBox))
            {
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                foreach (DemoDataModel item in listBox.Items)
                {
                    ListBoxItem listBoxItem = listBox.ItemContainerGenerator.ContainerFromItem(item) as ListBoxItem;
                    listBoxItem?.Show(true);
                }
            }
            else
            {
                key = key.ToLower();
                foreach (DemoDataModel item in listBox.Items)
                {
                    string name = item.Name.ToLower();
                    ListBoxItem listBoxItem = listBox.ItemContainerGenerator.ContainerFromItem(item) as ListBoxItem;
                    if (name.Contains(key))
                    {
                        listBoxItem?.Show(true);
                    }
                    else
                    {
                        listBoxItem?.Show(false);
                    }

                }
            }
        }

        private void ButtonAscending_OnClick(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton button && button.Tag is ItemsControl itemsControl)
            {
                if (button.IsChecked == true)
                {
                    itemsControl.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                }
                else
                {
                    itemsControl.Items.SortDescriptions.Clear();
                }
            }
        }

        private void ListBoxDemo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxDemo.SelectedItem == null)
            {
                return;
            };
            mainContent.Children.Clear();

            string name = (ListBoxDemo.SelectedItem as DemoDataModel).Name;
            string xaml = string.Format(@"..\Demos\{0}_Demo.xaml", name);
            string cs = string.Format(@"..\Demos\{0}_Demo.xaml.cs", name);
            string viewmodel = string.Format(@"..\ViewModel\{0}VM.cs", name);
            if (File.Exists(xaml))
            {
                xamlCode.Load(xaml);
            }
            else
            {
                xamlCode.Clear();
            }
            if (File.Exists(cs))
            {
                csCode.Load(cs);
            }
            else
            {
                csCode.Clear();
            }
            if (File.Exists(viewmodel))
            {
                viewModelCode.Load(viewmodel);
            }
            else
            {
                viewModelCode.Clear();
            }

            EnumMenu menu = (EnumMenu)Enum.Parse(typeof(EnumMenu), name, true);
            switch (menu)
            {
                case EnumMenu.Navigation3D:
                    _ = mainContent.Children.Add(new Navigation3D_Demo());
                    break;
                case EnumMenu.BasicControls:
                    _ = mainContent.Children.Add(new BasicControls_Demo());
                    break;
                case EnumMenu.PanningItems:
                    _ = mainContent.Children.Add(new PanningItems_Demo());
                    break;
                case EnumMenu.BreatheLight:
                    _ = mainContent.Children.Add(new BreatheLight_Demo());
                    break;
                case EnumMenu.Loading:
                    _ = mainContent.Children.Add(new Loading_Demo());
                    break;
                case EnumMenu.CutImage:
                    _ = mainContent.Children.Add(new CutImage_Demo());
                    break;
                case EnumMenu.AnimationAudio:
                    _ = mainContent.Children.Add(new AnimationAudio_Demo());
                    break;
                case EnumMenu.AMap:
                    _ = mainContent.Children.Add(new AMap_Demo());
                    break;
                case EnumMenu.ThumbAngle:
                    _ = mainContent.Children.Add(new ThumbAngle_Demo());
                    break;
                case EnumMenu.VerifyCode:
                    _ = mainContent.Children.Add(new VerifyCode_Demo());
                    break;
                case EnumMenu.CircularMenu:
                    _ = mainContent.Children.Add(new CircularMenu_Demo());
                    break;
                case EnumMenu.ChatEmoji:
                    _ = mainContent.Children.Add(new ChatEmoji_Demo());
                    break;
                case EnumMenu.ProgressBar:
                    _ = mainContent.Children.Add(new ProgressBar_Demo());
                    break;
                case EnumMenu.Dashboard:
                    _ = mainContent.Children.Add(new Dashboard_Demo());
                    break;
                case EnumMenu.PieControl:
                    _ = mainContent.Children.Add(new PieControl_Demo());
                    break;
                case EnumMenu.TimeLine:
                    _ = mainContent.Children.Add(new TimeLine_Demo());
                    break;
                case EnumMenu.Carousel:
                    _ = mainContent.Children.Add(new Carousel_Demo());
                    break;
                case EnumMenu.CarouselEx:
                    _ = mainContent.Children.Add(new CarouselEx_Demo());
                    break;
                case EnumMenu.Pagination:
                    _ = mainContent.Children.Add(new Pagination_Demo());
                    break;
                case EnumMenu.ScreenCut:
                    _ = mainContent.Children.Add(new ScreenCut_Demo());
                    break;
                case EnumMenu.TransitionPanel:
                    _ = mainContent.Children.Add(new TransitionPanel_Demo());
                    break;
                case EnumMenu.SpotLight:
                    _ = mainContent.Children.Add(new SpotLight_Demo());
                    break;
                case EnumMenu.DrawerMenu:
                    _ = mainContent.Children.Add(new DrawerMenu_Demo());
                    break;
                case EnumMenu.RainbowAppleButton:
                    _ = mainContent.Children.Add(new RainbowAppleButton_Demo());
                    break;
                case EnumMenu.RoundPicker:
                    _ = mainContent.Children.Add(new RoundPicker_Demo());
                    break;
                case EnumMenu.SnowCanvas:
                    _ = mainContent.Children.Add(new SnowCanvas_Demo());
                    break;
                case EnumMenu.EdgeLight:
                    _ = mainContent.Children.Add(new EdgeLight_Demo());
                    break;
                case EnumMenu.Shake:
                    _ = mainContent.Children.Add(new Shake_Demo());
                    break;
                case EnumMenu.Step:
                    _ = mainContent.Children.Add(new Step_Demo());
                    break;
                default:
                    break;
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("是否退出当前系统?", "询问", MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Grayscale_Click(object sender, RoutedEventArgs e)
        {
            if (grayscaleEffect.Factor == 1)
            {
                menuItemGrayscale.Header = "关闭灰度";
                Create(0);
            }

            else
            {
                menuItemGrayscale.Header = "开启灰度";
                Create(1);

            }
        }

        private void Create(double to)
        {
            SineEase sineEase = new SineEase() { EasingMode = EasingMode.EaseOut };
            DoubleAnimation doubleAnimation = new DoubleAnimation
            {
                To = to,
                Duration = TimeSpan.FromMilliseconds(1000),
                EasingFunction = sineEase
            };
            grayscaleEffect.BeginAnimation(GrayscaleEffect.FactorProperty, doubleAnimation);
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            NotifyIcon.ShowBalloonTip("Message", " Welcome to WPFDevelopers ", NotifyIconInfoType.None);
        }

        private void Twink_Click(object sender, RoutedEventArgs e)
        {
            WpfNotifyIcon.IsTwink = !WpfNotifyIcon.IsTwink;
            menuItemTwink.IsChecked = WpfNotifyIcon.IsTwink;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().Show();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}