using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }

        public Task(int id, string name, string desc)
        {
            ID = id;
            Name = name;
            Description = desc;
            IsFinished = false;
        }

        public void Print()
        {
            Console.WriteLine(" {0}| {1}", ID, Name);
            Console.WriteLine("    {0}", Description);
        }
    }
}
