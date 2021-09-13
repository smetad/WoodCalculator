using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WoodCalc_WPF._model
{
    public abstract class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) //jmeno vlastnoti je pouzito jako parametr
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
