using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class FullTaskViewModel : MvxViewModel
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

        private DateTime _dateSuccessTask;

        public DateTime DateSuccessTask
        {
            get => _dateSuccessTask;
            set 
            {
                _dateSuccessTask = value;
                RaisePropertyChanged(() => DateSuccessTask);
            }
        }

        private DateTime _dateControlTask;

        public DateTime DateControlTask
        {
            get => _dateControlTask;
            set 
            {
                _dateControlTask = value;
                RaisePropertyChanged(() => DateControlTask);
            }
        }

        private byte _priority;

        public byte Priority
        {
            get => _priority;
            set 
            {
                _priority = value;
                RaisePropertyChanged(() => Priority);
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

        public IMvxCommand ChangeTaskCommand { get; private set; }

        private void ChangeTask()
        {
            MessageBox.Show("test");
        }

        public FullTaskViewModel()
        {
            ChangeTaskCommand = new MvxCommand(ChangeTask);
        }
    }
}
