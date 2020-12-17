using System;

namespace testukas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string testdata = Console.ReadLine();

            if(testdata.Length > 0)
                Console.WriteLine($"{testdata[0]}{testdata}{testdata[0]}");
            else
                Console.WriteLine("MORE LETTERS PLS");

            Console.ReadLine();

        }
    }
}
