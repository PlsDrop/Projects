using System;
using System.Collections.Generic;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {   
            int counter = 0;
            
            //variant 1
            Task task1 = new Task();
            task1.title = "Buy some food";
            task1.description = "Buy: apple, juice, meat";
            task1.dueDate = "Apr 10";
            task1.done = true;
            //counter++;
            //Console.WriteLine(ToString(task1, counter));
            
            Task task2 = new Task();
            task2.title = "Eat some food";
            task2.dueDate = "Apr 11";
            task2.done = false;
            //counter++;
            //Console.WriteLine(ToString(task2, counter));

            //variant 2
            List<Task> tasks = new List<Task>();
            tasks.Add(task1);
            tasks.Add(task2);

            foreach (Task task in tasks)
            {
                counter++;
                Console.WriteLine(ToString(task, counter));
            }
        }

        static string ToString(Task task, int counter)
        {   
            var checkDone = task.done ? "[X]" : "[ ]";
            var checkDescr = task.description != null ? $"\n\t{task.description}" : "";
            var checkDate = task.dueDate != null ? $"({task.dueDate})" : "";
            return $"{counter,6}.\t{checkDone} {task.title} {checkDate}{checkDescr}";
        }
    }

    struct Task
    {
        public string title;
        public string description;
        public string dueDate;
        public bool done;
        
        //variant 3
        //public int id;
    }
}
