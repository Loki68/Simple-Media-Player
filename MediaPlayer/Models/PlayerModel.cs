using CustomMediaPlayer.Services;
using System;

namespace CustomMediaPlayer.Models
{
    class PlayerModel : IPlayerModel
    {
        IFileDialogService _fileDialogService;
        IPlaylistService _playlistService;

        public void SetFileDialogService(IFileDialogService fileDialogService)
        {
            _fileDialogService = fileDialogService;
        }

        public void SetPlaylistService(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }
    }
}
