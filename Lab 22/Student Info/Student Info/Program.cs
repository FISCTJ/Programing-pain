/****************************
 * title Student information
 * by Thomas Fischer
 * Date 30/05/2024
 ****************************/
using System;
using System.IO;

namespace Student_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            info[] entry = new info[27];

            //Console.WriteLine("This program adds people");
            //StreamWriter sw = new StreamWriter(@"Student_info.txt");
            //string temp;
            //int num;
            //int[] numbers = new int[10];
            //Console.WriteLine("Enter First name");
            //temp = Console.ReadLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    numbers[i] = num * (i + 1);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"First names {numbers[i]}");
            //    sw.WriteLine($"{numbers[i]}");

            //}
            //sw.Close();
            //Console.ReadLine();
            reader(ref entry);
            Console.ReadLine();
        }
        public struct info()
        {
            public string fnam;
            public string lnam;
            public string address;
            public string team;
        }
        static void reader(ref info [] entry)
        {
            StreamReader sr = new StreamReader(@"names.txt");
            int i = 0;
            Random = rant
            while (!sr.EndOfStream)
            {
                entry[i].fnam=sr.ReadLine();
                entry[i].lnam=sr.ReadLine();
                entry[i].address = "Dunedin";
                entry[i].team = random.next(1, 4);
                i++;
            }
            sr.Close();
        }
        static void writer()
        {
            StreamWriter sw = new StreamWriter(@"Our_class.txt");
            foreach ()
            {

            }
            
        }

    }
}
