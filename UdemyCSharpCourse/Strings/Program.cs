namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Steven";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();
            string lowerMessage = message.ToLower();

            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowerMessage);


            // define new variables
            int age = 39;
            string name = "Angus";
            string job = "Developer";

            // string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            // string formatting
            // string formatting using index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I'm a {2}", name, age, job);

            // string interpolation
            // string interpolation uses $ at the start which will allow us to write our variables like {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old. I'm a {job}");

            // verbatim strings
            // verbatim strings start with @ and tell the compiler to take the string literally and ignore any spaces and escape characters like \n

            // instead of using \\ to write file pathsverbatim strings can be used to make it easier
            // if @ is removed it will cause an error because \U, \A, and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            // with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!");


            string s1 = "this is a \"string\" with \na slash \\ and a colon: ";
            Console.WriteLine(s1);

            string myName;
            Console.WriteLine("Please enter your name and press enter: ");
            myName = Console.ReadLine();
            string myNameUpper = String.Format("Upper Case: {0}", myName.ToUpper());
            string myNameLower = String.Format("Lower Case: {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value: {0}", myName.Trim());
            string myNameSubString = String.Format("Substring value: {0}", myName.Substring(0, 5));

            Console.WriteLine(myName);
            Console.WriteLine(myNameUpper);
            Console.WriteLine(myNameLower);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);


        }
    }
}