namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 12, 21 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 }
            };

            Console.WriteLine("The value in the middle of the first entry is {0}",jaggedArray[0][2]);

            // my way to print the jaggedArray to console
            foreach (int[] array in jaggedArray)
            {
                Console.Write("The values for this array are: ");
                foreach(int num in array)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }

            // example given
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0} ", jaggedArray2[i][j]);
                }
            }

            Console.ReadLine();
        }
    }
}