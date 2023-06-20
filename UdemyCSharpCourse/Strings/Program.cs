namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Steven";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);
        }
    }
}