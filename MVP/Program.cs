using System;

namespace MVP
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ToDoList todo = new ToDoList();
                todo.PrintText();
                todo.Name = Console.ReadLine();
                Console.WriteLine();
                todo.PrintTask();
                todo.Task = Console.ReadLine();
                Console.WriteLine();
                todo.PrintDate();
                Console.WriteLine();
                Console.WriteLine();
            }


        }
    }
}
