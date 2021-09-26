using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Services;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.Models
{
    interface IPlayerModel
    {
        //string FileName { get; set; }
        //string FullFileName { get; set; }

        MediaContentDescription MediaContent { get; set; }
        ObservableCollection<MediaContentDescription> Playlist { get; set; }

        void SetFileDialogService(IFileDialogService fileService);
        void SetPlaylistService(IPlaylistService playlistService);

        void GetSingleFileInfo();
    }
}
