using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableCodingExercise
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void Call()
        {
            Console.WriteLine("Calling to {0}. Phone number is {1}", Name, Phone);
        }
    }
}
