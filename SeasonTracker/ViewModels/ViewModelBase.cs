using SeasonTracker.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using SeasonTracker.Views;

namespace SeasonTracker.ViewModels
{
    //Base class common for all viewmodels. 
    public class ViewModelBase
    {
        public AddTvShowCommand AddTvShowCommand { get; set; }
        public MyListCommand MyListCommand { get; set; }

        //Constructor - initialize all commands here...
        public ViewModelBase()
        {
            this.AddTvShowCommand = new AddTvShowCommand(this);
            this.MyListCommand = new MyListCommand(this);
        }

        //Method to be executed when the "Add Tv Show" button is clicked.
        public void AddTvShow()
        {
            AddTvShowWindow addTvShowWindow = new AddTvShowWindow();
            addTvShowWindow.ShowDialog();
        }

        //Method to be executed when the "My List" button is clicked.
        public void MyList()
        {
            //TBD Add method actions here...
        }
    }
}
