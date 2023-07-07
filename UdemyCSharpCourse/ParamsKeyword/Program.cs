namespace ParamsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int min = MinV2(6, 4, 2, 8, -20, 1, 5);

            Console.WriteLine("The minimum is: {0}", min);
        }

        public static int MinV2(params int[] numbers) 
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}