using CustomMediaPlayer.DTO;
using System.Collections.ObjectModel;

namespace CustomMediaPlayer.ViewModels
{
    interface IPlayerViewModel
    {
        MediaContentDescription SelectedMediaFile { get; set; }
        ObservableCollection<MediaContentDescription> Files { get; set; }
    }
}
