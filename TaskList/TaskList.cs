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
        List<Task> tempList = new List<Task>();
        List<Task> fullList = new List<Task>();
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
                    if (fullList.Contains(task))
                    {
                        fullList.Remove(task);
                    }
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
        public void sortList()
        {
            int input;
            Console.WriteLine("How do you want to sort the list?");
            Console.WriteLine("1.) Name");
            Console.WriteLine("2.) Priority");
            Console.WriteLine("3.) Due Date");
            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    tempList = Tasks.OrderBy(Task => Task._taskName).ToList();
                    Tasks = tempList;
                    break;
                case 2:
                    tempList = Tasks.OrderBy(Task => Task._priority).ToList();
                    Tasks = tempList;
                    break;
                case 3:
                    tempList = Tasks.OrderBy(Task => Task._date).ToList();
                    Tasks = tempList;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public void filterList()
        {
            int input;
            Console.WriteLine("How do you want to filter the list?");
            Console.WriteLine("1.) Show expired Tasks");
            Console.WriteLine("2.) Show pending Tasks");
            Console.WriteLine("3.) Show all Tasks");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    foreach(Task task in Tasks)
                    {
                        if (!fullList.Contains(task))
                        {
                            fullList.Add(task);
                        }
                    }
                    Tasks = fullList;
                    tempList = Tasks.Where(Task => Task._date.CompareTo(DateTime.Now) <= 0).ToList();
                    Tasks = tempList;
                    break;
                case 2:
                    foreach (Task task in Tasks)
                    {
                        if (!fullList.Contains(task))
                        {
                            fullList.Add(task);
                        }
                    }
                    Tasks = fullList;
                    tempList = Tasks.Where(Task => Task._date.CompareTo(DateTime.Now) >= 0).ToList();
                    Tasks = tempList;
                    break;
                case 3:
                    Tasks = fullList;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

        }
    }
}
