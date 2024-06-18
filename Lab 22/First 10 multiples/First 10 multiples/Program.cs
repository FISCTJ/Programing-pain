/****************************
 * title 10 multiples to file
 * by Thomas Fischer
 * Date 30/05/2024
 ****************************/
namespace First_10_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program collects 10 multiples");
            StreamWriter sw = new StreamWriter(@"Multiples.txt");
            string temp;
            int num;
            int[] numbers = new int[10];
            Console.WriteLine("Enter Multiple");
            temp = Console.ReadLine();
            num = Convert.ToInt32(temp);
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = num*(i+1);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Multiple {numbers[i]}");
                sw.WriteLine($"{numbers[i]}");

            }
            sw.Close();
            Console.ReadLine();
        }
    }
}
