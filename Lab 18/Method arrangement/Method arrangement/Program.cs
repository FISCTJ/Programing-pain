/****************************
 *  Title Method arrangement
 *  By Thomas Fischer
 *  Date: 16/05/2024
****************************/
using System.Runtime.CompilerServices;

namespace Method_arrangement
{
    internal class Program
    {
        public static void Main()
        {
            one();
            Console.ReadLine();
        }
        public static void one()
        {
            Console.WriteLine("The first method");
            two();
        }
        public static void two()
        {
            Console.WriteLine("The second method");
        }
    }
}
