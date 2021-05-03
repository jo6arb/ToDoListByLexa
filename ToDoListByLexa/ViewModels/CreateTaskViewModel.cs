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

        public IMvxCommand CreateTaskCommand => new MvxCommand(CreateTask);

        internal GoalViewModel GoalVM { get; set; }

        public override async Task Initialize() => await base.Initialize();

        private void CreateTask()
        {
            MessageBox.Show("Test test");
        }

        public CreateTaskViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            GoalVM = new GoalViewModel();
        }
    }
}
