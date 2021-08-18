using System;
using System.ComponentModel; // INotifyPropertyChanged
using System.Diagnostics;
using System.Runtime.CompilerServices; // CallerMemberName

namespace MultiplierSample
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value,
                                      [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            Debug.WriteLine("OnPropertyChanged propertyName: " + propertyName + " value: " + value);
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
