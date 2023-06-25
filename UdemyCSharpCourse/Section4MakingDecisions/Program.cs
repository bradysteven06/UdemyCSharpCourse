namespace Section4MakingDecisions
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Kevin";

        static void Main(string[] args)
        {
            //RegisterLogin();
            //Login();
            //Tempurature();
            //SwitchStatement();

            /*CheckHighscore(290, "Stuart");
            CheckHighscore(310, "Kevin");
            CheckHighscore(400, "Bob");*/

            TernaryOperator();

            Console.ReadLine();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " +  highscorePlayer);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore + " and held by " + highscorePlayer);
            }
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

        static void SwitchStatement()
        {
            int age = 25;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            string username = "Stuart";

            switch(username)
            {
                case "Kevin":
                    Console.WriteLine("username is Kevin!");
                    break;
                case "Bob":
                    Console.WriteLine("username is Bob!");
                    break;
                default:
                    Console.WriteLine("username is unknown!");
                    break;
            }
        }

        static void TernaryOperator()
        {
            // condition ? firstExpression : secondExpression;
            // condition has to be either true or false
            // the conditional operator is right - associative.
            // the expression a ? b : c ? d : e
            // is evaluated as a ? b : (c ? d : e),
            // not as (a ? b : c) ? d : e.
            // the conditional operator cannot be overloaded.

            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("state of matter is {0}", stateOfMatter);

            temperature += 30;

            // in short
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 100;

            // challenge - add the gas state of matter to the options
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
        }

    }
}