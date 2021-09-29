using CustomMediaPlayer.Models;
using CustomMediaPlayer.Services;
using CustomMediaPlayer.ViewModels;
using System.Windows;

namespace CustomMediaPlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IFileDialogService fileDialogService = new FileDialogService();

            IPlaylistService playlistService = new PlaylistService();

            IPlayerModel playerModel = new PlayerModel(fileDialogService,playlistService);

            MainWindow = new MainWindow
            {
                DataContext = new PlayerViewModel(playerModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
