using System.Windows;
using System.Windows.Input;
using ToDoListByLexa.Infrastructure.Commands;
using ToDoListByLexa.ViewModels.Base;

namespace ToDoListByLexa.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заговок окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _title = "Контроль мероприятий";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
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
            set => Set(ref _status, value);
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }


        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion
        }
    }
}
