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
    }
}
