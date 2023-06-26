namespace Section6ObjectOrientedProgramming
{
    // A class in C# (and most other object-oriented programminglanguages)
    // is a blueprint for creating objects.
    // It defines a wet of properties (data attributes)
    // and methods (functions) that an object of that class will have.
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car();
            audi.Drive();
            Car bmw = new Car();

            Console.WriteLine("Press 1 to stop the car!");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car keeps driving");
            }
        }
    }
}