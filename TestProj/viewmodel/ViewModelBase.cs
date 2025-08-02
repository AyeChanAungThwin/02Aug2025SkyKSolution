using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestProj.viewmodel
{
    public class ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}