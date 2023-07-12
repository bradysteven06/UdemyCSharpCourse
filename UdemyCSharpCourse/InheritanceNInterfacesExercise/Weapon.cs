using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceNInterfacesExercise
{
    class Weapon
    {
        public string Name { get; set; }

        public Weapon()
        {
            Name = "Weapon";
        }

        public Weapon(string name)
        {
            this.Name = name;
        }

        public void Label()
        {
            Console.WriteLine("This is {0}!", Name);
        }
    }
}
