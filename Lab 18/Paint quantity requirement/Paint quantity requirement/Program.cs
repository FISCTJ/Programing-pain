/****************************
 *  Title Paint requirements
 *  By Thomas Fischer
 *  Date: 16/05/2024
****************************/
using System.Formats.Asn1;
using System.Security.Cryptography;

namespace Paint_quantity_requirement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating how much paint is needed");
            Measurements();
        }
        private static double length, height, width, liter;
        public static void Measurements()
        {
            string temp;
            Console.WriteLine("Input the length please");
            temp = Console.ReadLine();
            length = Convert.ToDouble(temp);
            Console.WriteLine("Input the height please");
            temp = Console.ReadLine();
            height = Convert.ToDouble(temp);
            Console.WriteLine("Input the width please");
            temp = Console.ReadLine();
            width = Convert.ToDouble(temp);
            Calculations();
        }
        public static void Calculations()
        {
            double area, meter;
            area = (2 * width * height) + (2 * length * height) + (length * width);
            meter = 2 * area;
            liter = meter / 20;
            Results();
        }
        public static void Results()
        {
            Console.WriteLine($"You need {liter} liters of paint");
            Console.ReadLine();
        }
    }
}
