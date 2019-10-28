using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input; //needed for ICommand interface for button pressing

namespace SeasonTracker.ViewModels.Commands
{
    public class MyListCommand : ICommand
    {
        public MainWindowViewModel ViewModel { get; set; }

        //Constructor, passing the ViewModelBase. Set equal to the property ViewModel
        public MyListCommand(MainWindowViewModel viewModel)
        {
            this.ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.MyList();
        }
    }
}
