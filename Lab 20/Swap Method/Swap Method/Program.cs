/*****************************
 * title Swap Methodology
 * by Thomas Fischer
 * date 23/04/2024
*****************************/
using System;

namespace Swap_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int val1, val2;
            Console.WriteLine("Enter the first number");
            temp = Console.ReadLine();
            val1 = Convert.ToInt32(temp);
            Console.WriteLine("Enter the second number");
            temp = Console.ReadLine();
            val2 = Convert.ToInt32(temp);
            swap(ref val1, ref val2);
            Console.WriteLine($"here the first number you entered now swapped to {val1}\nand here is the second number now swapped {val2}");
            Console.ReadLine();
        }
        static void swap(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
