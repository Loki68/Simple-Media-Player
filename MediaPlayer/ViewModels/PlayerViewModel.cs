using CustomMediaPlayer.BaseINPC;
using CustomMediaPlayer.Commands;
using CustomMediaPlayer.DTO;
using CustomMediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomMediaPlayer.ViewModels
{
    class PlayerViewModel:BaseINPCImplementation,IPlayerViewModel
    {
        private readonly IPlayerModel _playerModel; 
        private ICommand _addCommand;
        private ICommand _clearCommand;
        

        public MediaContentDescription SelectedMediaFile
        {
            get => _playerModel.MdiaContentDescription;
            set { _playerModel.MdiaContentDescription = value;
                
                OnPropertyChanged(nameof(SelectedMediaFile));
            }
        }

        public ObservableCollection<MediaContentDescription> PlayList { get; private set; }
        public PlayerViewModel(IPlayerModel playerModel)
        {
            _playerModel = playerModel;
            PlayList = new ObservableCollection<MediaContentDescription>();
        }

        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null) _addCommand = new AddCommand(this);
                return _addCommand;
            }
        }

        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand == null) _clearCommand = new ClearCommand(this);
                return _clearCommand;
            }
        }

        public void AddRangeEl()
        {
            
            _playerModel.OpenFiles();
            foreach (var item in _playerModel.Playlist) 
                PlayList.Add(item);

            _playerModel.Playlist.Clear();
        }

        public void ClearPlaylist()
        {
            PlayList.Clear();

            _playerModel.Playlist.Clear();
        }
    }
}
