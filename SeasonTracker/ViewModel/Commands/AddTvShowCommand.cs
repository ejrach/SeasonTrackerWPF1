using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;     //needed for ICommand interface for button pressing

namespace SeasonTracker.ViewModel.Commands
{
    class AddTvShowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
