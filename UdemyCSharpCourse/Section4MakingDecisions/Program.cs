namespace Section4MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Login();
            //Tempurature();
        }

        static void Tempurature()
        {
            Console.Write("Enter the tempurature in degrees F: ");
            string tempurature = Console.ReadLine();
            int temp;

            int num;
            if (int.TryParse(tempurature, out num))
            {
                temp = num;
            }
            else
            {
                temp = 0;
                Console.WriteLine("Value entered, was not a number. Tempurature set to 0.");
            }

            if (temp < 50)
            {
                Console.WriteLine("Take a coat");
            }
            else if (temp == 50)
            {
                Console.WriteLine("It's 50 degrees F");
            }
            else
            {
                Console.WriteLine("It's cozy & warm");
            }
        }

        static void Login()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.Write("Please enter your username: ");
            userName = Console.ReadLine();

            if (userName == "Admin" || userName == "admin")
            {
                isAdmin = true;
            }

            if (isRegistered == true && userName != "")
            {
                
                if (isAdmin == true)
                {
                    Console.WriteLine("Hi there, Admin!");
                }
                else
                {
                    Console.WriteLine("Hi there, {0}.", userName);
                }
            }

            if (userName != "")
            {
                Console.WriteLine("You are logged in!");
            }
        }


    }
}