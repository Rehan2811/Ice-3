using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class ToDo
    {
        //Declaring variables
        private string description;
        private DateTime date;
        private Levels priority;

        //Getter and Setter
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public Levels Priority { get => priority; set => priority = value; }

        //Constructor
        public ToDo(string description, DateTime date, Levels priority)
        {
            this.description = description;
            this.date = date;
            this.priority = priority;
        }

        public enum Levels
        {
            Low,
            Medium,
            High
        }

        //Method
        public override string ToString()
        {
            return base.ToString();
        }
    }
}