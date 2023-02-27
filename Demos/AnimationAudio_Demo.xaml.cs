using System;
using System.IO;
using System.Windows.Controls;
using WPFDevelopers.Controls;
using WPFDevelopersDemo.Helpers;

namespace WPFDevelopersDemo.Demos
{
    /// <summary>
    /// AnimationAudio_Demo.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationAudio_Demo : UserControl
    {
        public AnimationAudio_Demo()
        {
            InitializeComponent();
            AnimationAudioLeft.AudioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Audio", "HelloWPFDevelopes_en.mp3");
            AnimationAudioRight.AudioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Audio", "HelloWPFDevelopes_zh.mp3");
        }

        private void AnimationAudioLeft_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AnimationAudio animationAudio = sender as AnimationAudio;
            System.Collections.Generic.List<AnimationAudio> animationAudioList = ElementVisualTreeHelper.FindVisualChild<AnimationAudio>(MyUniformGrid);
            if (animationAudioList == null)
            {
                return;
            }

            if (!animationAudio.IsPlay)
            {
                animationAudioList.ForEach(h =>
                {
                    if (h.IsPlay && h != animationAudio)
                    {
                        h.IsPlay = false;
                    }
                });
                animationAudio.IsPlay = true;
            }
            else
            {
                animationAudio.IsPlay = false;
            }
        }
    }
}