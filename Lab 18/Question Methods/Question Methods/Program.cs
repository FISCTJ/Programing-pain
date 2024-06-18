namespace Question_Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Question1();
        }
        public static void Question1()
        {
            string temp;
            do
            {
                Console.WriteLine("What is the name of this city?");
                temp = Console.ReadLine();
            }
            while (temp != "Dunedin");
            Console.WriteLine("You've answered correctly");
            Question2();
        }
        public static void Question2()
        {
            string temp;
            do
            {
                Console.WriteLine("What river runs through campus?");
                temp = Console.ReadLine();
            }
            while (temp != "Leith");
            Console.WriteLine("You've answered correctly");
            Question3();
        }
        public static void Question3()
        {
            string temp;
            do
            {
                Console.WriteLine("What is the city's most photographed building?");
                temp = Console.ReadLine();
            }
            while (temp != "Train station");
            Console.WriteLine("You've answered correctly");
            Complete();
        }
        public static void Complete()
        {
            Console.WriteLine("Congratulations you've completed this quiz");
            Console.ReadLine();
        }
    }
}
