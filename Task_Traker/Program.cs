namespace Task_Taker
{
    internal class Program
    {
        // Array to store tasks
        static string[] tasks = new string[100];

        static int TaskIndex = 0; // to keep track of number of tasks
        static void Main(string[] args)
        {
            // welcome to user
            // manage tasks => add, view,mark, delete
            // Exit

            Console.WriteLine("Welcome to Task Taker!");
            Console.WriteLine("  ==========================================  ");

            //Console.WriteLine("Please choose an option from 1 to 5 :");
            //string userChoise = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Please choose an option from 1 to 5 :");

                Console.WriteLine("1:Add");
                Console.WriteLine("2:View");
                Console.WriteLine("3:Complete");
                Console.WriteLine("4:Remove");
                Console.WriteLine("5:Exit");
             
                string userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        // add task
                        AddTask();
                        break;
                    case "2":
                        // view tasks
                        ViewTasks();
                        break;
                    case "3":
                        // mark task as complete
                        MarkTaskAsComplete();
                        break;
                    case "4":
                        // remove task
                        RemoveTask();
                        break;
                    case "5":
                        // exit
                        Environment.Exit(0); // terminates the program
                        break;
                    default:
                        Console.WriteLine("Invalid choice, Please enter number from 1 to 5.");
                        break;
                }
            }


        }

        private static void AddTask()
        {
            Console.WriteLine("Enter your Task ");
            string taskTitle = Console.ReadLine();
            tasks[TaskIndex] = taskTitle;
            Console.WriteLine("Task Added Successfully!");
            TaskIndex++;

        }

        private static void ViewTasks()
        {
            Console.WriteLine("Your Tasks:");
            for (int i = 0; i < TaskIndex; i++)
            {
                Console.WriteLine($"{i + 1  }. Task Title :  {tasks[i]}");
            }
        }

        private static void MarkTaskAsComplete()
        {
           
            Console.WriteLine("Enter task number want to mark");
            string input = Console.ReadLine();
            int taskId =  Convert.ToInt32(input);
            tasks[taskId] = tasks[taskId] + " --> Completed";
        }

        private static void RemoveTask()
        {
            
            Console.WriteLine("Enter task number to remove:");
            string input = Console.ReadLine();
            int taskId = Convert.ToInt32(input);
            tasks[taskId] = null;
        }
    }
}
