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
    }
}
