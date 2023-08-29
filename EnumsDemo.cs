using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalsDemo
{
    public class EnumsDemo
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void Enums()
        {
            Days day1 = Days.Monday;
            System.Console.WriteLine("Day in string - "+day1);
            System.Console.WriteLine("Day in int - "+(int) day1);

            Days day2 = Days.Tuesday;
            System.Console.WriteLine("Day in string - "+day2);
            System.Console.WriteLine("Day in int - "+(int) day2);

            Days day3 = Days.Wednesday;
            System.Console.WriteLine("Day in string - "+day3);
            System.Console.WriteLine("Day in int - "+(int) day3);

            Days day4 = Days.Thursday;
            System.Console.WriteLine("Day in string - "+day4);
            System.Console.WriteLine("Day in int - "+(int) day4);

            Days day5 = Days.Friday;
            System.Console.WriteLine("Day in string - "+day5);
            System.Console.WriteLine("Day in int - "+(int) day5);

            Days day6 = Days.Saturday;
            System.Console.WriteLine("Day in string - "+day6);
            System.Console.WriteLine("Day in int - "+(int) day6);

            Days day7 = Days.Sunday;
            System.Console.WriteLine("Day in string - "+day7);
            System.Console.WriteLine("Day in int - "+(int) day7);
        }
    }
}