using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// TransitionPanel_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class TransitionPanel_Demo : UserControl
    {
        private double RWidth { get; set; } = 0.0;

        public TransitionPanel_Demo()
        {
            InitializeComponent();

            Loaded += TransitionPanelExample_Loaded;
        }

        private void TransitionPanelExample_Loaded(object sender, RoutedEventArgs e)
        {
            RWidth = ActualWidth / 8;
            Height = ActualWidth;
            double leftX = 0.0;
            PART_Canvas.Height = ActualHeight * 0.8;
            Color color = (Color)ColorConverter.ConvertFromString("#FF5858F1");
            for (int i = 0; i < 10; i++)
            {
                string name = $"PART_Rectangle_{i}";
                Rectangle rect = new Rectangle
                {
                    Width = RWidth,
                    Height = ActualHeight,
                    Fill = new SolidColorBrush(color),
                    RenderTransformOrigin = new Point(0.5, 0.5),
                    Name = name
                };
                rect.RenderTransform = new SkewTransform
                {
                    AngleX = -25
                };
                _ = PART_Canvas.Children.Add(rect);
                leftX = !leftX.Equals(0.0) ? leftX + RWidth - 1 : -RWidth - 4;
                Canvas.SetLeft(rect, leftX);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation
            {
                To = 0,
                EasingFunction = new CircleEase { EasingMode = EasingMode.EaseIn }
            };

            if (btnContent.Content.ToString().Equals("下一步"))
            {
                foreach (Rectangle item in PART_Canvas.Children)
                {
                    string[] names = item.Name.Split('_');
                    DoubleAnimationDuration(doubleAnimation, names);
                    doubleAnimation.Completed += (s, n) =>
                    {
                        btnContent.Content = "上一步";
                    };
                    item.BeginAnimation(WidthProperty, doubleAnimation);
                }
            }
            else
            {
                doubleAnimation.To = RWidth;
                doubleAnimation.EasingFunction = new CircleEase { EasingMode = EasingMode.EaseOut };
                foreach (Rectangle item in PART_Canvas.Children)
                {
                    string[] names = item.Name.Split('_');
                    DoubleAnimationDuration(doubleAnimation, names);
                    doubleAnimation.Completed += (s, n) =>
                    {
                        btnContent.Content = "下一步";
                    };
                    item.BeginAnimation(WidthProperty, doubleAnimation);
                }
            }
        }

        private void DoubleAnimationDuration(DoubleAnimation doubleAnimation, string[] names)
        {
            if (names[2].Equals("7") || names[2].Equals("2"))
            {
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(200);
            }
            else if (names[2].Equals("0") || names[2].Equals("6"))
            {
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(250);
            }
            else if (names[2].Equals("4") || names[2].Equals("9"))
            {
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(300);
            }
            else if (names[2].Equals("1") || names[2].Equals("5"))
            {
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(400);
            }
            else
                doubleAnimation.Duration = TimeSpan.FromMilliseconds(500);
        }
    }
}
