using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace serviciosclima.viewmodel
{
    public class notificable: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProperty([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName= null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return;
            }
            backingField = value;
            onPropertyChanged(propertyName);
        }

        private void onPropertyChanged(string propertyName)
        {
            throw new NotImplementedException();
        }
    }
}
