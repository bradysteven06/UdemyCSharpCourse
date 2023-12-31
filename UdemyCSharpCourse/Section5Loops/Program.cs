﻿namespace Section5Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoops();
            //BreakContinue();
            AverageScore();
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
            int counter = 0;
            string input = "";
            while (counter < 10)
            {
                Console.WriteLine("Please press enter to increase4 amount by one and anything else + enter if you wan to finish counting.");
                input = Console.ReadLine();
                counter++;
                Console.WriteLine("Currentj people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
            Console.ReadLine();
        }

        static void BreakContinue()
        {
            Console.WriteLine("Count from 0 to 10.");
            for (int counter = 0; counter <= 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("skip 3");
                    continue;
                }
                else if (counter == 6)
                {
                    Console.WriteLine("stop at 6");
                    break;
                }
                Console.WriteLine(counter);
            }
        }

        public static void AverageScore()
        {
            int scoreTotal = 0;
            int userInput = 0;
            int scoreCount = 0;
            Console.WriteLine("Enter the each score then enter -1 to see the average.");

            do
            {
                Console.Write("Enter score: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out userInput))
                {
                    Console.WriteLine("Enter a valid number for the score.");
                }
                else
                {
                    if (userInput < 0 || userInput > 20)
                    {
                        if (userInput != -1)
                        {
                            Console.WriteLine("The score was not in the valid scoring range 0-20.");
                        }
                    }
                    else
                    {
                        scoreTotal += userInput;
                        scoreCount++;
                    }
                }
            } while (userInput != -1);

            Console.WriteLine("The average is : " + scoreTotal / scoreCount);
        }
    }
}