namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(15, 31));
            Console.WriteLine(Subtract(15, 31));
            Console.WriteLine(Divide(15, 31));

            string friend1 = "Kevin";
            string friend2 = "Stuart";
            string friend3 = "Bob";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            int num3 = 0;
            int num4 = 0;
            string symbol;
            Console.WriteLine("Enter two numbers and the operator +, -, *, or /");
            Console.Write("Number 1: ");
            try
            {
                num3 = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Invalid input. Enter a valid number next time.");
            }
            Console.Write("Number 2: ");
            try
            {
                num4 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a valid number next time.");
            }
            Console.Write("Operator: ");
            symbol = Console.ReadLine();

            if (symbol == "+")
            {
                Console.WriteLine(Add(num3, num4));
            }
            else if (symbol == "-")
            {
                Console.WriteLine(Subtract(num3, num4));
            }
            else if (symbol == "*")
            {
                Console.WriteLine(Multiply(num3, num4));
            }
            else if (symbol == "/")
            {
                Console.WriteLine(Divide(num3, num4));
            }
            else
            {
                Console.WriteLine("Valid operator not entered");
            }

            Console.ReadLine();

        }

        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am call from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi {0}, my friend!", friendName);
        }
    }
}