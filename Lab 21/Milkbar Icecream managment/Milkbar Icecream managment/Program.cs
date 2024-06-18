/************************************
 * title Milk-bar management
 * by Thomas Fischer
 * Date 28/05/2024
 ************************************/
namespace Milkbar_Icecream_managment
{
    public struct icecreams
    {
        public string name, flavour;
        public double cost; 
        public int number;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            icecreams frozencream;
            Console.WriteLine("What icecream would you like");
            frozencream.name = Console.ReadLine();
            frozencream.flavour = Console.ReadLine();
            frozencream.cost = 30;
            frozencream.number = 3;
            Console.WriteLine($"{frozencream.name} {frozencream.flavour} {frozencream.cost} {frozencream.number}");
            icecreams[] icetypes = new icecreams[5];
            icetypes[0].name = "Choc bar";
            icetypes[0].flavour = "one";
            icetypes[0].cost = 3;
            icetypes[0].number = 1;
            icetypes[1].name = "2" ;
            Console.ReadLine();
        }
        
    }
}
