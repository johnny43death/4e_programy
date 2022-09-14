using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class TaskManager
    {
        private IList<Task> _taskmanager;

        public TaskManager()
        {
            _taskmanager = new List<Task>();
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _taskmanager;
        }

        private int generateID()
        {
            int id = 1;
            if (_taskmanager.Any())
            {
                id = _taskmanager.Max(a => a.ID) + 1;
            }
            return id;
        }

        public void PrintAllTasks()
        {
            foreach (Task task in _taskmanager)
            {
                if (!task.IsFinished)
                {
                    task.Print();
                }
            }
        }

        public void PrintFinishedTasks()
        {
            foreach (Task task in _taskmanager)
            {
                if (task.IsFinished)
                {
                    task.Print();
                }
            }
        }

        public Task CreateTask(string name, string desc)
        {
            int id = generateID();
            Task task = new Task(id, name, desc);
            _taskmanager.Add(task);
            return task;
        }

        public Task SelectTask(int taskNo)
        {
            return _taskmanager.SingleOrDefault(x => x.ID == taskNo);
        }
    }
}
