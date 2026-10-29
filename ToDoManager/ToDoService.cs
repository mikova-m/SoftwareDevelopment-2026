using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class ToDoService
    {
        private readonly List<Task> tasks = new List<Task>();
        private static int nextId = 1;

        public List<Task> GetAll()
        {
            return tasks;
        }

        public Task FindById(int Id)
        {
            foreach (Task task in tasks)
            {
                if(task.Id == Id) return task;
            }
            return null;
        }

        public void Add(string title, string description, DateTime deadline)
        {
            Task newTask = new Task(nextId, title, description, deadline);
            tasks.Add(newTask);
            nextId++;
        }

        public void Completed(int id)
        {
            Task task = FindById(id);

            if(task == null)
            {
                throw new ArgumentException("Няма задача с такова Id.");
            }

            //task.CompleteTask();
        }
    }
}
