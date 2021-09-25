using CustomMediaPlayer.Services;

namespace CustomMediaPlayer.Models
{
    interface IPlayerModel
    {
        string FileName { get; set; }
        string FullFileName { get; set; }
        void SetFileDialogService(IFileDialogService fileService);
        void SetPlaylistService(IPlaylistService playlistService);
    }
}
