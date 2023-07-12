using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    class Dog
    {
        // the name of the dog
        public string Name { get; set; }
        // is this a naughty dog
        public bool IsNaughtyDog { get; set; }

        // simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        // this method will print how many treats the dog recieved
        public void GiveTreat(int numberOfTreats)
        {
            // print a message containing the number of treats and the name of the dog
            Console.WriteLine("Dog: {0} said woof {1} times!", Name, numberOfTreats);
        }
    }
}
