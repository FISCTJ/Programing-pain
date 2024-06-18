/****************************
 *  Title Menu Method
 *  By Thomas Fischer
 *  Date: 16/05/2024
****************************/
namespace Menu_Method
{
    internal class Program
    {
        static void Main()
        {
            string temp;
            int usr;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu's options are:\n1  Task1\n2  Task2\n3  Task3\n4  Task4\n0  Exit system menu");
                temp = Console.ReadLine();
                usr = Convert.ToInt32(temp);
                Console.Clear();
                switch (usr)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    default:
                        Console.WriteLine("Enter one of the specified");
                        break;

                }
            }
            while (usr != 0);
            Console.WriteLine("You may exit now");
            Console.ReadLine();
        }
        public static void task1()
        {
            Console.WriteLine("This is task 1\npush enter go home");
            Console.ReadLine();   
        }
        public static void task2()
        {
            Console.WriteLine("This is task 2\npush enter go home");
            Console.ReadLine();
        }
        public static void task3()
        {
            Console.WriteLine("This is task 3\npush enter go home");
            Console.ReadLine();
        }
        public static void task4()
        {
            Console.WriteLine("This is task 4\npush enter go home");
            Console.ReadLine();
        }
    }
}
