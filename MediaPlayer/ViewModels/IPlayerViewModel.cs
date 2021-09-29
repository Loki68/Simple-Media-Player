using CustomMediaPlayer.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediaPlayer.ViewModels
{
    interface IPlayerViewModel
    {
        ObservableCollection<MediaContentDescription> PlayList { get;  }
        MediaContentDescription SelectedMediaFile { get; set; }
        void AddRangeEl();
        void ClearPlaylist();
    }
}
