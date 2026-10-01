using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, DateTime deadLine)
        {
            Title = title;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = false;
        } 
    }
}
