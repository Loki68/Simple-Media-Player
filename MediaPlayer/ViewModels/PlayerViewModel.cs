using CustomMediaPlayer.BaseINPC;
using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Models;
using System;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.ViewModels
{
    class PlayerViewModel : BaseINPCImplementation, IPlayerViewModel
    {

        private readonly IPlayerModel _playerModel;

        public PlayerViewModel(IPlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        public MediaContentDescription SelectedMediaFile 
        { 
            get => _playerModel.MediaContent;
            set
            { 
                _playerModel.MediaContent = value;
                OnPropertyChanged(nameof(SelectedMediaFile));
            } 
        }

        public ObservableCollection<MediaContentDescription> Files 
        {
            get => _playerModel.Playlist;
            set => throw new NotImplementedException(); 
        }
    }
}
