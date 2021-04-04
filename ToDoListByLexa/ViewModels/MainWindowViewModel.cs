using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Windows;

namespace ToDoListByLexa.ViewModels
{
    internal class MainWindowViewModel : MvxViewModel
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

        public CreateTaskViewModel CreateTask { get; set; }
        public FullTaskViewModel FullTask { get; set; }
        public ShortInfotaskViewModel ShortTask { get; set; }

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

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new MvxCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion

            CreateTask = new CreateTaskViewModel();
            FullTask = new FullTaskViewModel();

            
        }
    }
}
