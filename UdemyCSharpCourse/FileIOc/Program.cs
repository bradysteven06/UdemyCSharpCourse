namespace FileIOc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\FileIOc\assets\highscores.txt", lines);
            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"F:\C# Masterclass Course\Projects\Assets\" + fileName + ".txt", input);
            */
            // Method 3
            using (StreamWriter file = new StreamWriter(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\FileIOc\assets\myText2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\FileIOc\assets\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }

/*
            //Reading Text from a File
            //exchange the address of the file with the one you want to use
            string text = System.IO.File.ReadAllText(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\FileIOc\assets\textfile.txt");

            Console.WriteLine("Textfile contains the following text: {0}", text);

            //Receive the Text line by line.
            string[] lines = System.IO.File.ReadAllLines(@"D:\Courses\UdemyC#Course\UdemyCSharpCourse\UdemyCSharpCourse\FileIOc\assets\textfile.txt");

            Console.WriteLine("Content of the file line by line:");
            foreach (string line in lines)
            {
                //\t is a tab
                Console.WriteLine( "\t" + line);
            }

            //To keep the Console open.
            Console.Read();
*/
        }
    }
}