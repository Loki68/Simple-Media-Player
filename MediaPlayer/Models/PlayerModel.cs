using CustomMediaPlayer.Services;
using System;

namespace CustomMediaPlayer.Models
{
    class PlayerModel : IPlayerModel
    {
        private string _fileName;

        public string FileName
        {
            get => _fileName;
            set => _fileName = value;
        }


        private string _fullFileName;

        public string FullFileName
        {
            get => _fullFileName; 
            set => _fullFileName = value; 
        }

        //добавить допинфу к данным-время и т.д.

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
