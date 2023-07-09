using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {
        // properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // simple constructor
        public Animal(string name, int age) 
        { 
            Name = name;
            Age = age;
            // in our case all our animals are hungry by default
            IsHungry = true;
        }

        // an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {
            
        }

        public virtual void Eat()
        {
            // check if animal is hungry
            if ( IsHungry )
            {
                // if yes then print the name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating.");
            }
            else
            {
                // otherwise print that the animal is not hungry
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }

    }
}
