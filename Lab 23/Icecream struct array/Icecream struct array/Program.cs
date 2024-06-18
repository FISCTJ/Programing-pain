/*********************************
 * title Ice cream struct & array
 * by Thomas Fischer
 * date 6/06/2024
 *********************************/
using System.Numerics;
using System.Xml.Linq;

namespace Icecream_struct_array
{
    public struct icecream
    {
        public string name, manufacturer;
        public int decade;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            icecream[] ice = new icecream[22];
            int index = 0;
            StreamReader str = new StreamReader(@"icecream.txt");
            while (!str.EndOfStream)
            {
                ice[index].name = str.ReadLine();
                ice[index].manufacturer = str.ReadLine();
                ice[index].decade = Convert.ToInt32(str.ReadLine());
                index++;
            }
            str.Close();
            Console.ReadLine();
        }
    }
}
