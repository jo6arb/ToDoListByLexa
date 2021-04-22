using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class MainScreenViewModel : MvxViewModel
    {
        #region Заговок окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _title = "Контроль мероприятий";

        public string Title
        {
            get => _title;
            set 
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        #endregion

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

        //public CreateTaskViewModel CreateTask { get; set; }
       // public FullTaskViewModel FullTask { get; set; }
       // public ShortInfotaskViewModel ShortTask { get; set; }
        private readonly IMvxNavigationService _navigationService;

        #endregion

        #region Команды

        #region CloseApplicationCommand

        public IMvxCommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute() => true;

        private void OnCloseApplicationCommandExecuted()
        {
            Application.Current.Shutdown();
        }


        #endregion

        #endregion
        public override async Task Initialize() => await base.Initialize();

        public MainScreenViewModel()
        {
         
        }

        public MainScreenViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
