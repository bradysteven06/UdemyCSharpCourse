using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6ObjectOrientedProgramming
{
    class Members
    {
        // member - private field
        private string _memberName;
        private string _jobTitle;
        private int _salary;

        // member - public field
        public int age;

        // member - property - exposes _jobTitle safely
        public string JobTitle 
        { 
            get
            {
                return _jobTitle;
            }
            set
            {
                _jobTitle = value;
            }

        }

        // member constructor
        public Members()
        {
            age = 30;
            _memberName = "Lucy";
            _salary = 60000;
            _jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        // only use if you are going to use it, don't make an empty one
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Destruction of Members object");
            Debug.Write("Destruction of Members object");
        }

        // public member Method - can be call from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", _memberName, _jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", _salary);
        }
    }
}
