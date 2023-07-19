using System.Security.Cryptography;

namespace RandomT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }

            FortuneTeller();

            Console.ReadLine();
        }

        static void FortuneTeller()
        {
            Random num = new Random();
            int randomNum = num.Next(1, 3);

            Console.WriteLine("Ask a question get an answer.");
            Console.Write("What is your question? ");
            Console.ReadLine();

            if (randomNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if (randomNum == 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Maybe");
            }
        }
    }
}