namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task list:");
            Console.WriteLine("1. Calculation of the surface of a circle and the length of a circle");
            Console.WriteLine("2. Currency converter");
            Console.WriteLine("3. Age calculation");
            Console.Write("To select one of the tasks, enter its number:");
            short taskNumber = Convert.ToInt16(Console.ReadLine());
            switch(taskNumber)
            {
                case 1:
                    FirstTask.Task();
                    break;
                case 2:
                    SecondTask.Task();
                    break;
                case 3:
                    ThirdTask.Task();
                    break;
                default:
                    Console.WriteLine("Task Not Found!");
                    break;
            }
        }
    }
}
