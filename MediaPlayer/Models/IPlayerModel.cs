using CustomMediaPlayer.Services;

namespace CustomMediaPlayer.Models
{
    interface IPlayerModel
    {
        void SetFileDialogService(IFileDialogService fileService);
        void SetPlaylistService(IPlaylistService playlistService);
    }
}
