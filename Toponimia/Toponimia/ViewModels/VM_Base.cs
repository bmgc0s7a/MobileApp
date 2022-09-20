using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Toponimia.ViewModels
{
    public class VM_Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokeEvent(object classe, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(classe, args);
        }
    }
}
