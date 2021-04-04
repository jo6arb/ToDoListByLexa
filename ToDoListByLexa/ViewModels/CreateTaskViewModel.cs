using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class CreateTaskViewModel : MvxViewModel
    {
        private string _headline;

        public string Headline
        {
            get => _headline;
            set 
            {
                _headline = value;
                RaisePropertyChanged(() => Headline);
            } 
        }

        private DateTime _dateAddTask;

        public DateTime DateAddTask
        {
            get => _dateAddTask;
            set 
            {
                _dateAddTask = value;
                RaisePropertyChanged(() => DateAddTask);
            }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set 
            {
                _description = value;
                RaisePropertyChanged(() => Description);                
            } 
        }

        public IMvxCommand CreateTaskCommand { get; private set; }

        private void CreateTask()
        {
            MessageBox.Show("Test test");
        }

        public CreateTaskViewModel()
        {
            CreateTaskCommand = new MvxCommand(CreateTask);
        }
    }
}
