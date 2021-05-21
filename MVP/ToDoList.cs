using System;


namespace MVP
{
    class ToDoList
    {
        public ToDoList()
        {
            
        }
        private string name;
        private string task;
        public DateTime createDate { get; set; } = DateTime.Now;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Task
        {
            get { return task; }
            set { task = value; }
        }

        public void PrintText()
        {
            Console.WriteLine($"Введите название задачи: {Name}");
        }
        public void PrintTask()
        {
            Console.WriteLine($"Введите задачу: {Task}");
        }
        public void PrintDate()
        {
            Console.WriteLine($"Время создания задачи: {createDate}");
        }
    }
}
