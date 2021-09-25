using CustomMediaPlayer.Models;
using System.Windows.Input;

namespace CustomMediaPlayer.ViewModels
{
    interface IPlayerViewModel
    {
        IPlayerModel SelectedMediaFile { get; set; }
        //ObservableCollection
        ICommand PlayCommand();
        ICommand PauseCommand();
    }
}
