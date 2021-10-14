using System;
using System.IO;
namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            //Dummy Data
            Task task1 = new Task("Matura", 5, "25/05/2022");
            Task task2 = new Task("Ball", 2, "16/10/2021");
            Task task3 = new Task("VERTS", 1, "15/10/2021");
            Task task4 = new Task("AWS", 5, "22/10/2021");
            Task task5 = new Task("Zocken", 4, "23/11/2021");
            Task task6 = new Task("Leben", 3, "19/07/2027");
            Task task7 = new Task("Sterben", 3, "19/07/2007");
            taskList.AppendTask(task1);
            taskList.AppendTask(task2);
            taskList.AppendTask(task3);
            taskList.AppendTask(task4);
            taskList.AppendTask(task5);
            taskList.AppendTask(task6);
            taskList.AppendTask(task7);

            InsertTask insertTask = new InsertTask();
            int input;
            do
            {
                Console.Clear();
                taskList.PrintList();
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1.) Add Task");
                Console.WriteLine("2.) Update Task");
                Console.WriteLine("3.) Delete Task");
                Console.WriteLine("4.) Sort");
                Console.WriteLine("5.) Filter");
                Console.WriteLine("6.) Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        taskList.AppendTask(insertTask.Insert());
                        break;
                    case 2:
                        taskList.UpdateTask();
                        break;
                    case 3:
                        taskList.DeleteTask();
                        break;
                    case 4:
                        taskList.sortList();
                        break;
                    case 5:
                        taskList.filterList();
                        break;
                    default:
                        break;
                }
            } while (input != 6);
            
            
                
            //Anfangs Liste zeigen
            //mit Tasten:
            //      neu erstellen
            //      Updaten
            //      Filtern
            //      Löschen

            
            //string fullpath = Path.GetFullPath("database.txt");
            //Console.WriteLine(fullpath);

            /*
            string test = Console.ReadLine();
            using (StreamWriter file = new("database.txt", append: true))
            {
                file.WriteLine(test);
            }

            string read = File.ReadAllText("database.txt");
            Console.WriteLine(read);
            */
            
        }
    }
}