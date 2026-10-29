using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class Task
    {
        private bool isCompleted;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool IsCompleted
        {
            get
            {
                return isCompleted;
            }
            private set
            {
                isCompleted = value;
            }
        }

        public Task(int id, string title, string description, DateTime deadLine)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id трябва да е положително!");
            }
           
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Заглавието е задължително!");
            }//свързано с try catch
            Id = id;
            Title = title;
            Description = description;// ako napravim if za opisanie se svurzva sus sushtiq try catch!
            DeadLine = deadLine;
            IsCompleted = false;
        } 
    }
}
