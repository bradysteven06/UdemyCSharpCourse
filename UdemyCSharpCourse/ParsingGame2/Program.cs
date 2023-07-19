using System;
using System.Text.RegularExpressions;

namespace ParsingGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\ParsingGame2\assets\input2.txt");
            string pattern = @"\b\d{2,3}\b";

            Regex regex = new Regex(pattern);

            foreach (string line in lines)
            {
                MatchCollection matchingIntegers = regex.Matches(line);
                foreach (Match integer in matchingIntegers)
                {
                    int num = int.Parse(integer.Value);
                    Console.WriteLine((char)num);
                }
            }


            Console.ReadLine();
        }
    }
}