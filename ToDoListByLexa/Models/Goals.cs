using System;

namespace ToDoListByLexa.Models
{
    internal class Goals
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateAddGoal { get; set; }

        public DateTime DateSuccessGoal { get; set; }

        public DateTime DateConrtolGoal { get; set; }

        public byte Priority { get; set; }

        public string Note { get; set; }
    }
}
