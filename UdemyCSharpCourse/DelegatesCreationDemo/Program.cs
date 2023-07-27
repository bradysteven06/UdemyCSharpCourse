namespace DelegatesCreationDemo
{
    internal class Program
    {
        // defining a delegate type called FilterDelegate that takes 
        // a person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Create 4 Person objects
            Person p1 = new Person() { Name = "Kevin", Age = 40 };
            Person p2 = new Person() { Name = "Bob", Age = 69 };
            Person p3 = new Person() { Name = "Stuart", Age = 25 };
            Person p4 = new Person() { Name = "Gru", Age = 12 };
            Person p5 = new Person() { Name = "Alvin", Age=28 };

            // add the objects to a list call people
            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            DisplayPeople("Kids", people, IsMinor);
            Console.WriteLine();
            DisplayPeople("Adults", people, IsAdult);
            Console.WriteLine();
            DisplayPeople("Seniors", people, IsSenior);

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            Console.WriteLine();
            DisplayPeople("Between 20 and 30", people, filter);

            Console.WriteLine();
            // example using anonymous method as the third paraemeter
            DisplayPeople("All: ", people, delegate (Person p) { return true; });

            Console.WriteLine();
            // Lambda Expressions
            string searchKeyword = "A";
            // Statement Lambda example
            DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine();
            // Expression Lambda example
            DisplayPeople("exactly 25: ", people, p => p.Age == 25);
        }

        // a method to display the list of people that passes the filter condition
        // (returns tru)
        // this method will take a title to be displayed, the list of people,
        // and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // print the title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // check if this person passes the filter
                // check if this person passes the filterd
                if (filter(p))
                {
                    // print the person's name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        //==========FILTERS==========
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}