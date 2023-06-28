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
            /*Car myCar = new Car();
            myCar.MaxSpeed = 100;
            Console.WriteLine(myCar.Name);
            Console.WriteLine("My car's max speed is: " + myCar.MaxSpeed);
            myCar.Details();

            Car audi = new Car("Audi A4", 250, "blue");
            audi.Drive();
            Car bmw = new Car("BMW M5", 350);
            bmw.Drive();

            audi.Details();
            bmw.Details();

            Console.WriteLine("Press 1 to stop the car!");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car keeps driving");
            }*/

            Members member1 = new Members();
            member1.Introducing(true);

        }
    }
}