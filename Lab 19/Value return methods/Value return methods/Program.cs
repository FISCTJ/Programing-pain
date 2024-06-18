/************************
 * title value methods
 * by Thomas Fischer
 * Date 21/05/2024
 ***********************/
namespace Value_return_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int usr;
            Console.WriteLine("Enter number to be altered");
            temp = Console.ReadLine();
            usr = Convert.ToInt32(temp);
            Console.WriteLine(square(usr));
            Console.WriteLine(cube(usr));
            Console.WriteLine(twotimes(usr));
            Console.WriteLine(half(usr));
            Console.ReadLine();
        }

        static int square(int num)
        {
            int square;
            square = num * num * num * num;
            return square;
        }
        static int cube(int num)
         {
             int cube;
             cube = num * num * num;
             return cube;

         }
         static int twotimes(int num)
         {
             int twotimes;
             twotimes = num * 2;
             return twotimes;
         }
         static double half(int num)
         {
             double half;
             half = num * 0.5;
             return half;
         }
    }
}
