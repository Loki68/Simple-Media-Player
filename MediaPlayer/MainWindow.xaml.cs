using Microsoft.Win32;
using System;
using System.Windows;

namespace CustomMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool onPaused = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void open_Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if (openFile.FileName.Length == 0) return;

            video.Source = new Uri(openFile.FileName);
            time.Content=openFile.SafeFileName;
            mediaTimeLine.Value = mediaTimeLine.Minimum;
            volume.Value = 20;
            video.Play();
        }

        private void pause_Btn_Click(object sender, RoutedEventArgs e)
        {
            //time.Content = video.Position.ToString(@"/mm/:ss");
            if(onPaused)
            {
                volume.Value = 15;
                video.Play();
                onPaused = false;
            }
            else
            {
                video.Pause();
                onPaused = true;
            }
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            video.Volume = volume.Value / 100;
        }

        private void stop_Btn_Click(object sender, RoutedEventArgs e)
        {
            video.Stop();
            mediaTimeLine.Value = mediaTimeLine.Minimum;
        }

        private void mediaTimeLine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sliderValue = (int)mediaTimeLine.Value;
            TimeSpan time = new TimeSpan(0, 0, 0, 0, sliderValue);
            video.Position = time;
        }

        private void video_MediaOpened(object sender, RoutedEventArgs e)
        {
            mediaTimeLine.Maximum = video.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
    }
}
