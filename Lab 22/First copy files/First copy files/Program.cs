/***********************
 * title Copy files 
 * by Thomas Fischer
 * Date 30/05/2024
 ***********************/
namespace First_copy_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aLine;
            StreamReader str = new StreamReader(@"names.txt");
            while (!str.EndOfStream)
            {
                aLine = str.ReadLine();
                Console.WriteLine(aLine);
            }
            str.Close();
            Console.ReadLine();
        }
    }
}
