using CustomMediaPlayer.ViewModels;

namespace CustomMediaPlayer.Commands
{
    class ClearCommand : BaseCommandImplementation
    {
        public ClearCommand(IPlayerViewModel playerViewModel)
            :base(playerViewModel)
        {
            
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            playerViewModel.ClearPlaylist();
        }
    }
}
