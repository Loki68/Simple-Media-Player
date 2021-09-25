using CustomMediaPlayer.Models;
using CustomMediaPlayer.Services;
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

            IPlayerModel playerModel = new PlayerModel();
            playerModel.SetFileDialogService(fileDialogService);
            playerModel.SetPlaylistService(playlistService);

            base.OnStartup(e);
        }
    }
}
