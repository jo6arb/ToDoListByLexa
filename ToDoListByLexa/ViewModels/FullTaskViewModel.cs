using System;
using System.Windows;
using System.Windows.Input;
using ToDoListByLexa.Infrastructure.Commands;
using ToDoListByLexa.ViewModels.Base;

namespace ToDoListByLexa.ViewModels
{
    internal class FullTaskViewModel : ViewModel
    {
        private string _headline;

        public string Headline
        {
            get => _headline;
            set => Set(ref _headline, value);
        }

        private DateTime _dateAddTask;

        public DateTime DateAddTask
        {
            get => _dateAddTask;
            set => Set(ref _dateAddTask, value);
        }

        private DateTime _dateSuccessTask;

        public DateTime DateSuccessTask
        {
            get => _dateSuccessTask;
            set => Set(ref _dateSuccessTask, value);
        }

        private DateTime _dateControlTask;

        public DateTime DateControlTask
        {
            get => _dateControlTask;
            set => Set(ref _dateControlTask, value);
        }

        private byte _priority;

        public byte Priority
        {
            get => _priority;
            set => Set(ref _priority, value); 

        }

        private string _description;

        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        public ICommand ChangeTaskCommand { get; private set; }

        private void ChangeTask(object parameter)
        {
            MessageBox.Show("test");
        }

        public FullTaskViewModel()
        {
            ChangeTaskCommand = new LambdaCommand(ChangeTask);
        }
    }
}
