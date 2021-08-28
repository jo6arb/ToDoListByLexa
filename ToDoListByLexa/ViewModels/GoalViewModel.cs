using MvvmCross.ViewModels;
using System;

namespace ToDoListByLexa.ViewModels
{
    internal class GoalViewModel : MvxViewModel
    {

        #region Id

        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(() => Id);
            }
        }
        #endregion
        
        #region Name

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        #endregion

        #region DateAddTask
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
        #endregion

        #region DateSuccessTask
        private DateTime _dateSuccessTask;

        public DateTime DateSuccessTask
        {
            get => _dateSuccessTask;
            set
            {
                _dateAddTask = value;
                RaisePropertyChanged(() => DateSuccessTask);
            }
        }
        #endregion

        #region DateControlTask
        private DateTime _dateControlTask;

        public DateTime DateControlTask
        {
            get => _dateControlTask;
            set
            {
                _dateAddTask = value;
                RaisePropertyChanged(() => DateControlTask);
            }
        }
        #endregion

        #region Priority
        private byte _priority;

        public byte Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                RaisePropertyChanged(() => Priority);
            }
        }
        #endregion
        
        #region Note
        private string _note;

        public string Note
        {
            get => _note;
            set
            {
                _note = value;
                RaisePropertyChanged(() => Note);
            }
        }
#endregion
        
    }
}
