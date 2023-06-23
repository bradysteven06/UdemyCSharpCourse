namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();


        }

        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am call from a method.");
            Console.ReadLine();
        }
    }
}