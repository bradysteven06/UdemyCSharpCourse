﻿using System;

namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1983, 7, 6);

            Console.WriteLine("My birthday is {0}", dateTime);

            // Write today on screen
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);


            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(1983));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}", now.Minute);

            Console.WriteLine("{0} o'clock {0} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            /*Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }*/
            DaysPastBDay();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

        static void DaysPastBDay()
        {
            Console.WriteLine("Write your birth date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime dateTime))
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since birth date: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}