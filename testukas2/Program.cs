using System;
using System.Globalization;

namespace testukas2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a month number:");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            DateTimeFormatInfo mfi = new DateTimeFormatInfo();
            string strMonthName = mfi.GetMonthName(monthNumber).ToString();           
            
            Console.WriteLine(strMonthName);
            Console.ReadLine();
        }
    }
}
