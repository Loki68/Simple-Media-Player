using CustomMediaPlayer.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CustomMediaPlayer.ViewModels
{
    interface IPlayerViewModel
    {
        IPlayerModel SelectedMediaFile { get; set; }
        ObservableCollection<IPlayerModel> Files { get; set; }
    }
}
