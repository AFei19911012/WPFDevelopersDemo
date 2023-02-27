using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// CutImage_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class CutImage_Demo : UserControl
    {
        public CutImage_Demo()
        {
            InitializeComponent();

            btnImport.Click += OnImportClickHandler;
            btnSave.Click += BtnSave_Click;
        }

        private void OnImportClickHandler(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "图像文件(*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                cutCustoms.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                btnSave.IsEnabled = true;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                FileName = $"{DateTime.Now:yyyyMMddHHmmss}.jpg",
                DefaultExt = ".jpg",
                Filter = "image file|*.jpg"
            };

            if (dlg.ShowDialog() == true)
            {
                BitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create((BitmapSource)image2.ImageSource));
                using (var fs = System.IO.File.OpenWrite(dlg.FileName))
                {
                    pngEncoder.Save(fs);
                    fs.Dispose();
                    fs.Close();
                }
            }
        }
    }
}
