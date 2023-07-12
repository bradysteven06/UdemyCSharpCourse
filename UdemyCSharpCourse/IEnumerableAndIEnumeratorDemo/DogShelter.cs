using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumeratorDemo
{
    // a class named DogShelter. this class contains a generic collection of type Dog
    // objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface
    class DogShelter : IEnumerable<Dog>
    {
        // list of type List<Dog>
        public List<Dog> dogs;

        // this constructor will initialize the dogs list with some values
        public DogShelter()
        {
            // initialize the dogs list using the collection-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
