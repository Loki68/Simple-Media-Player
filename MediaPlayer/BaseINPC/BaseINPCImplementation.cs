using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomMediaPlayer.BaseINPC
{
    class BaseINPCImplementation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
