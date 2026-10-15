using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string title, string description, DateTime deadLine)
        {
            Id = id;
            Title = title;
            Description = description;
            DeadLine = deadLine;
            IsCompleted = false;
        } 
    }
}
