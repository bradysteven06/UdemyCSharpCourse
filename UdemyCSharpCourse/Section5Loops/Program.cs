namespace Section5Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoops();
        }

        static void ForLoops()
        {
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static void DoWhileLoops()
        {
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.Write("Please enter the name of a friend: ");
                string nameOfFriend = Console.ReadLine();
                int currentLength = nameOfFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);
        }

        static void  WhileLoops()
        {

        }

        static void BreakContinue()
        {

        }
    }
}