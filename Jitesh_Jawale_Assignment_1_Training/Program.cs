using System;
using System.Collections.Generic;

namespace Jites_Jawale_Assignment_1_project
{
    internal class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("\nJitesh Jawale Project\n");
            while (true)
            {
                Console.WriteLine("1. Create a task");
                Console.WriteLine("2. Read tasks");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Give your input:- ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateTask();
                        break;
                    case 2:
                        ReadTasks();
                        break;
                    case 3:
                        UpdateTask();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                //  Console.WriteLine("\n\n");
            }
        }

        static void CreateTask()
        {
            Console.WriteLine("\nEnter the title of the task:");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("\nTask Added Successfully \n");
        }

        static void ReadTasks()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine("\nTask List finished\n");
        }

        static void UpdateTask()
        {
            Console.WriteLine("\nEnter the number of the task you want to update:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the new title of the task:");
            string newTask = Console.ReadLine();
            tasks[taskNumber - 1] = newTask;
            Console.WriteLine("\nTask Updation Successful \n");
        }

        static void DeleteTask()
        {
            Console.WriteLine("\nEnter the number of the task you want to delete:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("\nTask Deletion Successful \n");
        }
    }
}
