using System.Diagnostics.Tracing;
using System.Linq.Expressions;

namespace ParsingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\ParsingGame\assets\input.txt");
            
            using (StreamWriter file = new StreamWriter(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\ParsingGame\assets\output.txt"))
            {
                foreach (string line in lines)
                {
                    //Console.WriteLine(line);
                    if (line.Contains("split"))
                    {
                        string[] words = line.Split(' ');
                        file.Write(words[4] + " ");

                    }
                }
            }
        }
    }
}