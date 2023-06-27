using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6ObjectOrientedProgramming
{
    internal class Car
    {
        // Member variables
        private string _name; // private field typically used for storing data.
        private int _hp;
        private string _color;

        // Constructor
        public Car(string name, int hp = 0, string color = "black") 
        {
            _name = name;
            _hp = hp;
            Console.WriteLine(name + " was created!");
        }

        // Member methods
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine("The " + _color + " car " + _name + " has " + _hp + " hp.");
        }
    }
}
