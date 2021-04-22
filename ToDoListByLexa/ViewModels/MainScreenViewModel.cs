using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class MainScreenViewModel : MvxViewModel
    {
        
        #region Status : string - статус программы


        /// <summary>
        /// Статус программы
        /// </summary>
        private string _status = "Готов!";

        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                RaisePropertyChanged(() => Status);
            }
        }

        #endregion

        private readonly IMvxNavigationService _navigationService;

        #region Команды

        public IMvxCommand CloseApplicationCommand => new MvxCommand(CloseApplications);
        public IMvxAsyncCommand GoToCreateNewTaskCommand => new MvxAsyncCommand(GoToCreateTaskAsync);

        
        private void CloseApplications()
        {
            Application.Current.Shutdown();
        }


        #endregion

        public override async Task Initialize() => await base.Initialize();

        public MainScreenViewModel() { }


        public MainScreenViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private async Task GoToCreateTaskAsync() => await _navigationService.Navigate<CreateTaskViewModel>();
    }
}
