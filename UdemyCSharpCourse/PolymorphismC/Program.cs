namespace PolymorphismC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a car can be a BMW, an Audi, a Porsche etc.
            // Polymorphism at work #1: an Audi,  BMW, Porsche
            // can all be used whereever a Car is expected. No cast is
            // required because an implicit conversion exists from a derived 
            // class to its base class.
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Polymorphism at work #2: the virtual method Repair is
            // invoked on each of the derived classes, not the base class.
            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Steven Brady");
            audiA3.SetCarIDInfo(1235, "Kevin Mino");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();
            Console.ReadKey();
        }
    }
}