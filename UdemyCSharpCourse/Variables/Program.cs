namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring multiple variables at once
            int num3, num4, num5;
            // declaring a variable
            int num1;
            // assigning a value to a variable
            num1 = 13;

            int num2 = 23;
            
            num2 = 100;

            // using concatination
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 is " + dIDiv);
            

            Console.ReadLine();
        }
    }
}