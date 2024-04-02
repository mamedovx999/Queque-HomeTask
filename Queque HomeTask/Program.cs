namespace Queque_HomeTask
{
    internal class Program
    {
        #region task1
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add Task");
                Console.WriteLine("2.Show All Task");
                Console.WriteLine("3.Show Next Task");
                Console.WriteLine("4.Completed Task");
                Console.WriteLine("5.Exit");
                string chocce = Console.ReadLine();

                switch (chocce)
                {
                    case "1":
                        Console.WriteLine("Enter task");
                        string Newtask = Console.ReadLine();
                        taskManager.AddTask(Newtask);
                        break;
                    case "2":
                        taskManager.ShowAllTask();
                        break;
                    case "3":
                        taskManager.ShowNextTask();
                        break;
                    case "4":
                        taskManager.CompleteTask();
                        break;
                    case "5":
                        Console.WriteLine("Exit Program");
                        break;
                    default:
                        Console.WriteLine("Yeniden Yoxlayin");
                        break;
                }
            }
        }
        #endregion

        #region Task2

        //Dictionary<int, int> Groups = new();
        //AddGroup(1, 10, Groups);
        //AddGroup(2, 10, Groups);
        //AddGroup(3, 50, Groups);
        //AddGroup(6, 30, Groups);
        //AddGroup(4, 70, Groups);
        //RemoveGroup(3, Groups);
        //ShowAllGroups(Groups);
        #endregion


        private Queue<string> tasks = new Queue<string>();

        public void AddTask(string task)
        {
            Console.WriteLine($"{task} elave edildi ");
        }
        public void ShowAllTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Siyahi bosdur");
                return;
            }
            Console.WriteLine("All Task");
            int index = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine($"{index++}.{task}");
                return;
            }
        }
        public void ShowNextTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Siyahi bosdur");
                return;
            }
            Console.WriteLine($"NextTask : {tasks.Peek}");
        }
        public void CompleteTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Siyahida tamamlanmis task yoxdur");
                return;
            }
            string CompletedTask = tasks.Dequeue();
            Console.WriteLine($"{CompletedTask} tamamlandi ");
        }


    }
}
