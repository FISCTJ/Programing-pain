/**********************************
 * Title Numbers array bubble sort
 * by Thomas Fischer
 * date 11/06/2024
 **********************************/
namespace Numbers_array_Bubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number");
                temp = Console.ReadLine();
                numbers[i]= Convert.ToInt32(temp);
            }
            for  (int i = 0; i < numbers.Length; i++)
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
        }
    }
}
