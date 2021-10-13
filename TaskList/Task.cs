using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class Task
    {
        public string _taskName;
        int _priority;
        DateTime _date;

        public Task(string taskName, int priority, DateTime date)
        {
            _taskName = taskName;
            _priority = priority;
            _date = date;
        }


        public Task(string taskName, int priority, string date)
        {
            _taskName = taskName;
            _priority = priority;
            _date = DateTime.Parse(date);
        }

        public void printTask()
        {
            Console.WriteLine("Name: " + _taskName + ", Priority: " + _priority + ", Date: " + _date.ToString("dd/MM/yyyy"));
        }

        public void update(string taskName, int priority, DateTime date)
        {
            _taskName = taskName;
            _priority = priority;
            _date = date;
        }
    }
}
