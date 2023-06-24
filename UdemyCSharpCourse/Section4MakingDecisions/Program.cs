namespace Section4MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegisterLogin();
            //Login();
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

        static void RegisterLogin()
        {
            // register username
            // register password
            // get username
            // get password
            // check username
            // check password
            // display welcom message

            string userName;
            string password;
            string inputName;
            string inputPassword;

            Console.WriteLine("Welcome to registration!");
            Console.Write("Enter your desired username: ");
            userName= Console.ReadLine();
            Console.Write("Enter your desired password: ");
            password= Console.ReadLine();

            Console.WriteLine("Let's log in!");
            Console.Write("Enter your username: ");
            inputName= Console.ReadLine();
            Console.Write("Enter your password: ");
            inputPassword= Console.ReadLine();

            if (inputName == userName && inputPassword == password)
            {
                Console.WriteLine("Congratulation on logging in {0}", userName);
            }
            else if (inputName == userName && password != inputPassword)
            {
                Console.WriteLine("Invalid password for user {0}", userName);
            }
            else
            {
                Console.WriteLine("That user is not in the system.");
            }
        }


    }
}