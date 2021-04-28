using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    public class CreateTaskViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

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

        public IMvxCommand CreateTaskCommand => new MvxCommand(CreateTask);

        public override async Task Initialize() => await base.Initialize();

        private void CreateTask()
        {
            MessageBox.Show("Test test");
        }

        public CreateTaskViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
