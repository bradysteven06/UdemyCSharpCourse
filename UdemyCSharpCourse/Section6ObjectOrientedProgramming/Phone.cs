using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6ObjectOrientedProgramming
{
    // copied from udemy course challenge
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }

        public Phone(string company, string model)
        {
            Company = company;
            Model = model;
            ReleaseDay = "unknown";
        }

        public Phone(string company, string model, string releaseDay)
        {
            Company = company;
            Model = model;
            ReleaseDay = releaseDay;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

    public class Run
    {
        public static void RunExercise()
        {
            Phone one = new Phone();
            Phone two = new Phone("Apple", "IPhone 12");
            Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

            one.Introduce();
            two.Introduce();
            three.Introduce();
        }

    }
}
