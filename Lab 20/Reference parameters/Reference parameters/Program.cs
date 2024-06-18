/*****************************
 * title reference_parameter
 * by Thomas Fischer
 * date 23/04/2024
*****************************/
namespace Reference_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            double num;
            Console.WriteLine("Enter the numbers: ");
            temp = Console.ReadLine();
            num = Convert.ToDouble(temp);
            muliplyed(ref num);
            Console.WriteLine($"number muliplyed my 15% is {num}");
            Console.ReadLine();
        }
        static void muliplyed (ref double num)
        {
            num = num * 1.15;
        }
        
    }
}



