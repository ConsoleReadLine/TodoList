using System;


namespace ToDoList.ConsoleApp
{
    class ToDoList
    {
        /// <summary>
        /// Все приватные поля начинаем с символа _
        /// Все публичные свойства с заглавной буквы
        /// </summary>
        /// 
        
        public ToDoList()
        {
            
        }
        private string _name;
        private string _task;
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Task
        {
            get { return _task; }
            set { _task = value; }
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
            Console.WriteLine($"Время создания задачи: {CreateDate}");
        }
    }
}
