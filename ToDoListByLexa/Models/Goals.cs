using System;
using System.ComponentModel;

namespace ToDoListByLexa.Models
{
    public class Goals
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateAddGoal { get; set; }

        public DateTime DateSuccessGoal { get; set; }

        public DateTime DateContolGoal { get; set; }

        public byte Priority { get; set; }

        public string Note { get; set; }

        
    }
}
