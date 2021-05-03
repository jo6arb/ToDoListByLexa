using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoListByLexa.Models;

namespace ToDoListByLexa.ViewModels
{
    internal class GoalViewModel : MvxViewModel
    {

        internal Goals Goal { get; set; }
        #region headline
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

        #region Deskription
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
#endregion

        public GoalViewModel()
        {
            Goal = new Goals();
        }


    }
}
