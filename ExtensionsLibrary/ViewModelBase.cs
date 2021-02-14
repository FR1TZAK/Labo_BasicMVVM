using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExtensionsLibrary
{

    // REUSING THIS FOR ALL VIEWMODELS in AppWPF
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler _propertyChangedEvent;

        public virtual event PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChangedEvent += value; }
            remove { _propertyChangedEvent -= value; }
        }

        public void Notify([CallerMemberName] string prop = "")
        {
            if(_propertyChangedEvent != null)
            {
                _propertyChangedEvent(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
