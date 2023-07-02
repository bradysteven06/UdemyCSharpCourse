using System.Runtime.ExceptionServices;

namespace Section7Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            //Console.WriteLine("grades at index 0 : {0}", grades[0]);

            //string input = Console.ReadLine();
            // assign value to array grades at index 0
            //grades[0] = int.Parse(input);
            //Console.WriteLine("grades at index 0 : {0}", grades[0]);
            //Console.ReadLine();

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            //Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
            //Console.ReadLine();

            // Arrays
            /*int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Elelment{0} = {1}", j, nums[j]);
            }
            Console.ReadLine();

            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Element{0} = {1}", counter, k);
                counter++;
            }

            string[] friends = {"Kevin", "Stuart", "Bob", "Luffy", "Nami"};
            foreach(string name in friends)
            {
                Console.WriteLine("Hello {0}, how are you today?", name);
            }*/

            // Multi Dimensional Arrays

            // 2D Array
            string[,] matrix;

            // 3D Array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3 },  // row0
                {4, 5, 6 },  // row1
                {7, 8, 9 }   // row2
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Hi there", "What's up"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Another one", "Last entry"}
                }
            };

            Console.WriteLine("The value is {0}", array3D[1, 2, 1]);

            string[,] array2DString = new string[,]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;
            Console.WriteLine(dimensions);

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

        }
    }
}