namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // list of names
            List<string> names = new List<string>() { "Kevin", "Bob", "Stuart", "Gru" };

            Console.WriteLine("----before----");
            // print the names before the RemoveAll method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // call RemoveAll and pass in the Filter method
            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            // print the names after the RemoveAll method was called
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // a mehtod called Filter that takes a string
        static bool Filter(string s)
        {
            // return whether the sting s contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}