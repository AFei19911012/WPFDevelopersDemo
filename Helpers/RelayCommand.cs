using System;
using System.Windows.Input;

namespace WPFDevelopersDemo.Helpers
{
    ////
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2023 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2023/2/26 23:30:32
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2023/2/26 23:30:32                     BigWang         首次编写         
    ///
    public class RelayCommand : ICommand
    {
        private readonly Func<object, bool> canExecuteFunc;
        private readonly Action<object> executeAction;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            if (execute == null)
            {
                return;
            }

            executeAction = execute;
            canExecuteFunc = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecuteFunc == null || canExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (executeAction == null)
            {
                return;
            }

            executeAction(parameter);
        }
    }
}