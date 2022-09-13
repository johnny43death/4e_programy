using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class CurrentTasks
    {
        private IList<Task> _currtasks;

        public CurrentTasks()
        {
            _currtasks = new List<Task>();
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _currtasks;
        }

        private int generateID()
        {
            int id = 1;
            if (_currtasks.Any())
            {
                id = _currtasks.Max(a => a.ID) + 1;
            }
            return id;
        }

        public Task CreateTask(string name, string desc)
        {
            int id = generateID();
            Task account = new Task(id, name, desc);
            _currtasks.Add(account);
            return account;
        }

        public Task GetTask(string taskNo)
        {
            return _currtasks.SingleOrDefault(x => x.ID == int.Parse(taskNo));
        }

        public void PrintAllTasks()
        {
            foreach (Task task in _currtasks)
            {
                if (!task.IsFinished)
                {
                    task.Print();
                }
            }
        }
    }
}
