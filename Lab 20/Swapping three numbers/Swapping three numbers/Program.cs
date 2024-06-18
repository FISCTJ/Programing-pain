/*******************************
 * title Swapping three numbers
 * by Thomas Fischer
 * date 23/04/2024
*******************************/
namespace Swapping_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Statesort(1, 2, 3));

        }
        public static int Statesort(int number1, int number2, int number3)
        {
            int temp;
            int[] numbers = new int[3];
            numbers[0] = number1;
            numbers[1] = number2;
            numbers[2] = number3;
            for (int i = 0;i < numbers.Length;i++)
            {
                for (int j = i+1; j < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        temp= numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
        /*static void swap(ref int numbers)
        {
            int temp = numbers;
            numbers[1] = numbers[2];
            numbers[2] = numbers[3];
            numbers = temp;
        }*/
    }
}
