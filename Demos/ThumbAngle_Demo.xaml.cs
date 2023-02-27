using System.Windows.Controls;
using System.Windows.Documents;
using WPFDevelopers.Controls;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// ThumbAngle_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class ThumbAngle_Demo : UserControl
    {
        public ThumbAngle_Demo()
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                AdornerLayer al = AdornerLayer.GetAdornerLayer(_border);
                al.Add(new ElementAdorner(_border));
            };
        }
    }
}