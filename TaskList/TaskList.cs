using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    class TaskList
    {
        List<Task> Tasks = new List<Task>();

        public void AppendTask(Task task)
        {
            Tasks.Add(task);
        }
        public void PrintList()
        {
            foreach (Task task in Tasks){
                task.printTask();
            }
        }
        public void DeleteTask()
        {
            string input;
            Console.WriteLine("Write the name of the task you want to delete:");
            input = Console.ReadLine();
            foreach (Task task in Tasks)
            {
                if(task._taskName == input)
                {
                    Tasks.Remove(task);
                    break;
                }
            }    
        }
        public void UpdateTask()
        {
            string input;
            Console.WriteLine("Write the name of the task you want to update:");
            input = Console.ReadLine();
            foreach (Task task in Tasks)
            {
                if(task._taskName == input)
                {
                    task.printTask();
                    string taskName;
                    int priority;
                    DateTime date;
                    Console.WriteLine("Name for Task:");
                    taskName = Console.ReadLine();
                    Console.WriteLine("Priority:");
                    priority = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Duedate DD/MM/YYYY:");
                    date = DateTime.Parse(Console.ReadLine());
                    task.update(taskName, priority, date);
                    break;
                }
            }
        }
    }
}
