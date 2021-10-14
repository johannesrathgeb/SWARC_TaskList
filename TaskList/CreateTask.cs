using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
namespace TaskList
{
    class CreateTask
    {
        public Task Create()
        {
            string taskName;
            int priority;
            DateTime date;
            Console.WriteLine("Name for Task:");
            taskName = Console.ReadLine();
            Console.WriteLine("Priority:");
            priority = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duedate DD/MM/YYYY:");
            date = DateTime.Parse(Console.ReadLine());

            Task newTask = new(taskName, priority, date);

            return newTask;
        }
    }
}