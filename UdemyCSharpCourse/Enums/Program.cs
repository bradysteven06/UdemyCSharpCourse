﻿namespace Enums
{
    internal class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su}
        enum Month { January = 1, February, March, April, May, June, July = 12, August, September, October, November, December}

        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.January);
            Console.WriteLine((int)Month.August);

            Console.ReadLine();
        }
    }
}