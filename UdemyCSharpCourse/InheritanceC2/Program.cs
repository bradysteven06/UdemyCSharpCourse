namespace InheritanceC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee mike = new Employee("Miller", "Mike", 40000);

            mike.Work();
            mike.Pause();

            Boss chuck = new Boss("Jeep", "Norris", "Chuck", 120000);
            chuck.Lead();

            Trainee michelle = new Trainee(32, 8, "Gartner", "Michelle", 10000);
            michelle.Learn();
            michelle.Work();
        }
    }
}