using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace CustomMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool onPaused = true;
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(0.1);
            timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            mediaTimeLine.Value = video.Position.TotalSeconds;
        }

        private void open_Btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            //if(video.I) тут надо добавить проверку на воспроизведение.
            if (openFile.FileName.Length == 0) return;

            video.Source = new Uri(openFile.FileName);
            time.Content=openFile.SafeFileName;
            mediaTimeLine.Value = mediaTimeLine.Minimum;
            volume.Value = 20;
            //timer.Start();
            video.Pause();
            //onPaused = true;
        }

        private void pause_Btn_Click(object sender, RoutedEventArgs e)
        {
            //time.Content = video.Position.ToString(@"/mm/:ss");
            if(onPaused)
            {
                volume.Value = 15;
                video.Play();
                timer.Start();
                onPaused = false;
                
            }
            else
            {
                video.Pause();
                timer.Stop();
                onPaused = true;
            }
        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            video.Volume = volume.Value / 100;
        }

        private void stop_Btn_Click(object sender, RoutedEventArgs e)
        {
            video.Stop();
            mediaTimeLine.Value = mediaTimeLine.Minimum;
        }

        //private void mediaTimeLine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    int sliderValue = (int)mediaTimeLine.Value;
        //    //TimeSpan time = new TimeSpan(0, 0, 0, 0, sliderValue);
        //    //video.Position = time;
        //    video.Position = TimeSpan.FromSeconds(mediaTimeLine.Value);
        //}

        private void video_MediaOpened(object sender, RoutedEventArgs e)
        {
            mediaTimeLine.Maximum = video.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void mediaTimeLine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
        }
    }
}
