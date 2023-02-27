using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPFDevelopers.Controls;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// TimeLine_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class TimeLine_Demo : UserControl
    {
        private int Num { get; set; } = 0;

        public TimeLine_Demo()
        {
            InitializeComponent();
        }
 
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Num++;
            switch (Num)
            {
                case 1:
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = DateTime.Now.ToString("yyyy-MM-dd"), ItemType = ItemTypeEnum.Time });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "我是骗人布010", Head = "我", ItemType = ItemTypeEnum.Name, BackgroundColor = new SolidColorBrush(GetRandomColor()) });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "张三/WPFDevelopers", ItemType = ItemTypeEnum.Star });
                    break;
                case 2:
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), ItemType = ItemTypeEnum.Time });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "风云大陆", Head = "风", ItemType = ItemTypeEnum.Name, BackgroundColor = new SolidColorBrush(GetRandomColor()) });
                    break;
                case 3:
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"), ItemType = ItemTypeEnum.Time });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "王羲之", Head = "王", ItemType = ItemTypeEnum.Name, BackgroundColor = new SolidColorBrush(GetRandomColor()) });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "张三/WPFDevelopers", ItemType = ItemTypeEnum.Star });
                    break;
                case 4:
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd"), ItemType = ItemTypeEnum.Time });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "花雨", Head = "花", ItemType = ItemTypeEnum.Name, BackgroundColor = new SolidColorBrush(GetRandomColor()) });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "张三/WPFDevelopers", ItemType = ItemTypeEnum.Star });
                    break;
                case 5:
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd"), ItemType = ItemTypeEnum.Time });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "纪春庆", Head = "纪", ItemType = ItemTypeEnum.Name, BackgroundColor = new SolidColorBrush(GetRandomColor()) });
                    _ = TimeLine.Items.Add(new TimeLineItem() { Text = "张三/WPFDevelopers", ItemType = ItemTypeEnum.Star });
                    break;
                default:
                    break;
            }
        }
        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromRgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }
    }
}