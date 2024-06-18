/******************************
 * Title bubble sort icecreams
 * by Thomas Fischer
 * date 11/06/2024
 ******************************/
namespace Bubble_sort_Icecreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aLine;
            int numbers;
            StreamReader str = new StreamReader(@"icecream.txt");
            while (!str.EndOfStream)
            {
                aLine = str.ReadLine();
                Console.WriteLine(aLine);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int pos = 0; pos < numbers.Length - 1; pos++)
                {
                    if (numbers[pos + 1] < numbers[pos])
                    {
                        int temp1 = numbers[pos + 1];
                        numbers[pos + 1] = numbers[pos];
                        numbers[pos] = temp1;
                    }
                }
                Console.WriteLine(numbers[i]);
            }
            str.Close();
            Console.ReadLine();
        }
    }
}
