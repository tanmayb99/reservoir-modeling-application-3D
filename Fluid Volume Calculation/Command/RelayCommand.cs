using System;
using System.Windows.Input;

namespace Fluid_Volume_Calculation.Command
{
    public class RelayCommand : ICommand
    {
        Action<object> executeAction;
        Func<object, bool> canExecute;
        bool canExecuteCache;

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute = null, bool canExecuteCache = true)
        {
            this.canExecute = canExecute;
            this.executeAction = executeAction;
            this.canExecuteCache = canExecuteCache;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
    }
}
