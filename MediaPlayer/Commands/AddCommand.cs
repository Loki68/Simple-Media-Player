using CustomMediaPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMediaPlayer.Commands
{
    class AddCommand : BaseCommandImplementation
    {
        public AddCommand(IPlayerViewModel playerViewModel)
        :base(playerViewModel)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            playerViewModel.AddRangeEl();
        }
    }
}
