using System.ComponentModel;

namespace Finding_largest_entry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            first()second()third();
            Console.WriteLine();
            do
            {
                if (first > second)
                {
                    Console.WriteLine("The first is greator than second");
                }
                if (second < third)
                {
                    Console.WriteLine("second is less than third");
                }
            } while ("");
        }
        static int first()
        {
            Console.WriteLine("Enter the first number");
            first = Console.ReadLine();
        }
        static int second()
        {
            Console.WriteLine("Enter the Second number");
            second = Console.ReadLine();
        }
        static int third()
        {
            Console.WriteLine("Enter the third number");
            third = Console.ReadLine();
        }
    }
}
