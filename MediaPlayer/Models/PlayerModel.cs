using CustomMediaPlayer.BaseINPC;
using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Services;
using System;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.Models
{
    class PlayerModel : BaseINPCImplementation, IPlayerModel
    {
        //private string _fileName;

        //public string FileName
        //{
        //    get => _fileName;
        //    set => _fileName = value;
        //}


        //private string _fullFileName;

        //public string FullFileName
        //{
        //    get => _fullFileName; 
        //    set => _fullFileName = value; 
        //}
        private MediaContentDescription _mediaContent;
        private ObservableCollection<MediaContentDescription> _playlist;

        public MediaContentDescription MediaContent
        {
            get => _mediaContent; 
            set 
            { 
                _mediaContent = value;
                OnPropertyChanged(nameof(MediaContent));
            }
        }

        public ObservableCollection<MediaContentDescription> Playlist
        {
            get => _playlist; 
            set { _playlist = value; }
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

        public void GetSingleFileInfo()
        {
            _mediaContent = _fileDialogService.OpenSingleFile();
        }
    }
}
