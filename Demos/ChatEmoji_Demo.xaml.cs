using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using WPFDevelopers.Controls;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// ChatEmoji_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class ChatEmoji_Demo : UserControl
    {
        public IEnumerable EmojiArray
        {
            get => (IEnumerable)GetValue(EmojiArrayProperty);
            set => SetValue(EmojiArrayProperty, value);
        }

        public static readonly DependencyProperty EmojiArrayProperty =
            DependencyProperty.Register("EmojiArray", typeof(IEnumerable), typeof(ChatEmoji_Demo), new PropertyMetadata(null));

        public ChatEmoji_Demo()
        {
            InitializeComponent();

            Loaded += delegate
            {
                List<EmojiModel> emojiModels = new List<EmojiModel>();

                EmojiHelper.Instance._emojiHeight = 30;
                EmojiHelper.Instance._emojiWidth = 30;

                Dictionary<string, string> m_Emojis = new Dictionary<string, string>();
                string emojiPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "emoji");
                DirectoryInfo directory = new DirectoryInfo(emojiPath);
                foreach (FileInfo item in directory.GetFiles())
                {
                    string _key = $"[{Path.GetFileNameWithoutExtension(item.Name)}]";
                    m_Emojis.Add(_key, item.FullName);
                    emojiModels.Add(new EmojiModel { Name = Path.GetFileNameWithoutExtension(item.Name), Key = _key, Value = item.FullName });
                }
                EmojiHelper.Instance.m_Emojis = m_Emojis;

                EmojiArray = emojiModels;
            };
        }

        private void PART_Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LeftButtonEmoji.IsChecked = false;
            Border send = sender as Border;
            LeftInput.Text += send.Tag.ToString();
            _ = LeftInput.Focus();
            LeftInput.SelectionStart = LeftInput.Text.Length;
        }

        private void LeftSend_Click(object sender, RoutedEventArgs e)
        {
            LeftChat();
        }

        private void LeftChat()
        {
            ChatEmoji leftText = new ChatEmoji
            {
                IsRight = true,
                RightImageSource = new BitmapImage(new Uri("pack://application:,,,/Resource/Image/Chat/UserImages/jingtao.png")),
                Text = LeftInput.Text
            };
            Paragraph leftPara = new Paragraph
            {
                TextAlignment = TextAlignment.Right
            };
            leftPara.Inlines.Add(leftText);
            _LeftChat.Document.Blocks.Add(leftPara);


            ChatEmoji rightText = new ChatEmoji();
            rightText.IsRight = false;
            rightText.LeftImageSource = new BitmapImage(new Uri("pack://application:,,,/Resource/Image/Chat/UserImages/jingtao.png"));
            rightText.Text = LeftInput.Text;
            Paragraph rightPara = new Paragraph
            {
                TextAlignment = TextAlignment.Left
            };
            rightPara.Inlines.Add(rightText);
            _RightChat.Document.Blocks.Add(rightPara);

            LeftInput.Text = string.Empty;
            LeftInput.Focus();
        }

        private void RightChat()
        {
            ChatEmoji leftText = new ChatEmoji
            {
                IsRight = true,
                RightImageSource = new BitmapImage(new Uri("pack://application:,,,/Resource/Image/Chat/UserImages/yanjinhua.png")),
                Text = RightInput.Text
            };
            Paragraph leftPara = new Paragraph
            {
                TextAlignment = TextAlignment.Right
            };
            leftPara.Inlines.Add(leftText);
            _RightChat.Document.Blocks.Add(leftPara);


            ChatEmoji rightText = new ChatEmoji();
            rightText.IsRight = false;
            rightText.LeftImageSource = new BitmapImage(new Uri("pack://application:,,,/Resource/Image/Chat/UserImages/yanjinhua.png"));
            rightText.Text = RightInput.Text;
            Paragraph rightPara = new Paragraph
            {
                TextAlignment = TextAlignment.Left
            };
            rightPara.Inlines.Add(rightText);
            _LeftChat.Document.Blocks.Add(rightPara);

            RightInput.Text = string.Empty;
            RightInput.Focus();
        }

        private void RightSend_Click(object sender, RoutedEventArgs e)
        {
            RightChat();
        }

        private void PART_Border_RightPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RightButtonEmoji.IsChecked = false;
            Border send = sender as Border;
            RightInput.Text += send.Tag.ToString();
            _ = RightInput.Focus();
            RightInput.SelectionStart = RightInput.Text.Length;
        }
    }

    public class EmojiModel
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}