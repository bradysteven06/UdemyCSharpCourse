namespace Section4MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the tempurature in degrees F: ");
            string tempurature = Console.ReadLine();
            int temp = int.Parse(tempurature);

            Tempurature(temp);
        }

        static void Tempurature(int temp)
        {
            
            if (temp < 50)
            {
                Console.WriteLine("Take a coat");
            }

            if (temp ==  50)
            {
                Console.WriteLine("It's 50 degrees F");
            }

            if (temp > 50)
            {
                Console.WriteLine("It's cozy & warm");
            }
        }
    }
}