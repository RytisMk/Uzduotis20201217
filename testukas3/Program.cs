using System;

namespace testukas3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string testdata = Console.ReadLine();

            char[] charArray = testdata.ToCharArray();
            Array.Reverse( charArray );
            Console.WriteLine(new string(charArray));
            Console.ReadLine();
        }
    }
}
