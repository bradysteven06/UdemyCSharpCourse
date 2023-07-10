using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            LastName = "Brady";
            FirstName = "Steven";
            Salary = 50000;
        }

        public Employee(string lastName, string firstName, int salary) 
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I'm working.");
        }

        public void Pause()
        {
            Console.WriteLine("I'm taking a break.");
        }
    }
}
