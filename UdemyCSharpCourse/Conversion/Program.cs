﻿namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;


            // explicit conversion
            double myDouble = 13.37;
            int myInt;
            
            // cast double to int
            myInt = (int)myDouble;


            // typeConversion
            string myString = myDouble.ToString();
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myInt);
            Console.WriteLine(myString);
            Console.WriteLine(myFloatString);
            Console.WriteLine(myBoolString);
            Console.ReadLine();
        }
    }
}