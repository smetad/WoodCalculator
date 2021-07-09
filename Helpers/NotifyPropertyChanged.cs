using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace woodcalc_00._model
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
