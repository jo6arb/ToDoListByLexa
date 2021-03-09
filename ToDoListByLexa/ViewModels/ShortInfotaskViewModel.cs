using System;
using System.Windows;
using System.Windows.Input;
using ToDoListByLexa.Infrastructure.Commands;
using ToDoListByLexa.ViewModels.Base;

namespace ToDoListByLexa.ViewModels
{
    internal class ShortInfotaskViewModel : ViewModel
    {
        private string _headline;

        public string Headline
        {
            get => _headline;
            set => Set(ref _headline, value);
        }

        private DateTime _dateControlTask;

        public DateTime DateControlTask
        {
            get => _dateControlTask;
            set => Set(ref _dateControlTask, value);
        }


        private string _description;

        public string Description
        {
            get => _description;
            set => Set(ref _description, value);
        }

        public ICommand SuccessTaskCommand { get; private set; }

        private void SuccessTask(object paramert)
        {
            MessageBox.Show("test");
        }

        public ShortInfotaskViewModel()
        {
            SuccessTaskCommand = new LambdaCommand(SuccessTask);
        }

    }
}
