using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class ShortInfotaskViewModel : MvxViewModel
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

        public IMvxCommand SuccessTaskCommand { get; private set; }

        private void SuccessTask()
        {
            MessageBox.Show("test");
        }

        public ShortInfotaskViewModel()
        {
            SuccessTaskCommand = new MvxCommand(SuccessTask);
        }

    }
}
