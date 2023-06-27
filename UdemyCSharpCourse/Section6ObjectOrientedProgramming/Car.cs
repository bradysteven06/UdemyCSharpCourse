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
        // access modifier private
        private string _name; // private field typically used for storing data.
        private int _hp;
        private string _color;

        public int MaxSpeed { get; set; }


        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }

        // Partial Specification Constructor
        public Car(string name, int hp = 0) 
        {
            _name = name;
            _hp = hp;
            Console.WriteLine(name + " was created!");
            _color = "red";
        }

        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            _hp = hp;
            Console.WriteLine(name + " was created!");
            _color = color;
        }

        // public property
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
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

        public void Details()
        {
            Console.WriteLine("The " + _color + " car " + _name + " has " + _hp + " hp.");
        }
    }
}
