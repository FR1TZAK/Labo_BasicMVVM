using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ExtensionsLibrary
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            ClickAction?.Invoke(parameter); // the parameter from the UI passed as CommandParameter
        }


        private Action<object> _clickAction = null;

        public Action<object> ClickAction { get => _clickAction; set => _clickAction = value; }

        public RelayCommand(Action<object> execute)
        {
            ClickAction = execute;
        }
    }
}
