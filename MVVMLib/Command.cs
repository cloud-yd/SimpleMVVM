using System;
using System.Windows.Input;

namespace MVVMLib
{
    class Command : ICommand
    {
        private readonly Action<object> _command;
        public event EventHandler CanExecuteChanged;

        public Command(Action<object> command)
        {
            _command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            _command(parameter);
            //throw new NotImplementedException();
        }
    }
}
