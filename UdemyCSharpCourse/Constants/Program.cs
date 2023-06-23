namespace Constants
{
    // Constants are immutable values which are known
    // at compile time and do not change for the life of the program

    internal class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // create a constant of type string with your birthday as its value
        const string birthday = "07.06.1983";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be {0}", birthday );
        }
    }
}