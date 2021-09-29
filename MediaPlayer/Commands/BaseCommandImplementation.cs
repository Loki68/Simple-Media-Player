using CustomMediaPlayer.BaseINPC;
using CustomMediaPlayer.ViewModels;
using System;
using System.Windows.Input;

namespace CustomMediaPlayer.Commands
{
    abstract class BaseCommandImplementation : ICommand
    {
        protected IPlayerViewModel playerViewModel;
        public BaseCommandImplementation(IPlayerViewModel viewmodel)
        {
            playerViewModel = viewmodel;
        }

        public event EventHandler CanExecuteChanged;

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);
    }
}
