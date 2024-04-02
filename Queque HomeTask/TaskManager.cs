using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Queque_HomeTask
{
    public class TaskManager
    {
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
            if ( tasks.Count == 0)
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
