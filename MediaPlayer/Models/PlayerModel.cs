using CustomMediaPlayer.BaseINPC;
using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.Models
{
    class PlayerModel : BaseINPCImplementation, IPlayerModel
    {
        
        private readonly IFileDialogService _fileDialogService;
        private readonly IPlaylistService _playlistService;

        private List<MediaContentDescription> _playlist;
        private MediaContentDescription _mediaContentDescription;

        public PlayerModel(
            IFileDialogService fileDialogService, 
            IPlaylistService playlistService)
        {
            _fileDialogService = fileDialogService;
            _playlistService = playlistService;
        }

        public List<MediaContentDescription> Playlist
        {
            get => _playlist;
        }

        public MediaContentDescription MdiaContentDescription 
        {
            get => _mediaContentDescription;
            set => _mediaContentDescription = value;
        }
        //добавить допинфу к данным-время и т.д.

        public void OpenFiles()
        {
            _playlist = _fileDialogService.OpenFiles();
        }

    }
}
