using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ToDoListByLexa.Infrastructure.Commands;
using ToDoListByLexa.ViewModels.Base;

namespace ToDoListByLexa.ViewModels
{
    internal class CreateTaskViewModel : ViewModel
    {
        private string _headline;

        public string Headline
        {
            get => _headline;
            set { Set(ref _headline, value); }
        }

        private DateTime _dateAddTask;

        public DateTime DateAddTask
        {
            get => _dateAddTask;
            set { Set(ref _dateAddTask, value); }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set { Set(ref _description, value); }
        }

        public ICommand CreateTaskCommand { get; private set; }

        private void CreateTask(object parameter)
        {
            MessageBox.Show("Test test");
        }

        public CreateTaskViewModel()
        {
            CreateTaskCommand = new LambdaCommand(CreateTask);
        }
    }
}
