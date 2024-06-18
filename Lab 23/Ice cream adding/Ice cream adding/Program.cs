/**************************
 * title Ice cream adding
 * by Thomas Fischer
 * date 6/06/2024
 **************************/
using System.Numerics;
using System.Xml.Linq;

namespace Icecream_adding
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
            string adding;
            StreamReader str = new StreamReader(@"icecream.txt");
            while (!str.EndOfStream)
            {
                ice[index].name = str.ReadLine();
                ice[index].manufacturer = str.ReadLine();
                ice[index].decade = Convert.ToInt32(str.ReadLine());
                index++;
            }
            str.Close();
            add();
            static void add()
            {
                icecream[] ice = new icecream[22];
                int orleng;
                orleng = ice.Length;
                Array.Resize(ref ice, ice.Length + 2);
                Console.WriteLine("Add some more icecreams");

                for (int i = orleng; i < ice.Length; i++)
                {
                    Console.WriteLine("add icecream name");
                    ice[i].name = Console.ReadLine();
                    Console.WriteLine("add icecream manufacturer");
                    ice[i].manufacturer = Console.ReadLine();
                    Console.WriteLine("add icecream decade");
                    ice[i].decade = Convert.ToInt32(Console.ReadLine());
                }
            }
            
        }
    }
}
