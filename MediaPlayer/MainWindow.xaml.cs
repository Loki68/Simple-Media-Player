using Microsoft.Win32;
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
using System.Windows.Threading;

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
            if(openFile.FileName.Length!=0)video.Source = new Uri(openFile.FileName);
        }

        private void pause_Btn_Click(object sender, RoutedEventArgs e)
        {
            time.Content = video.Position.Seconds.ToString();
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
        }
    }
}
