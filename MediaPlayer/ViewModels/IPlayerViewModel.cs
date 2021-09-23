using System.Windows.Input;

namespace CustomMediaPlayer.ViewModels
{
    interface IPlayerViewModel
    {
        ICommand PlayCommand();
        ICommand PauseCommand();
        ICommand StopCommand();
    }
}
