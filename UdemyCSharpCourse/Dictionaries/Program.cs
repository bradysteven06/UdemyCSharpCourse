using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8)
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            // update dictionary entry
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated!.", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", KeyToUpdate);
            }

            // remove
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was Removed!.", keyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", keyToRemove);
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }

            Employee result = null;
            // using TryGetValue() is return s true if the operation was successful and false otherwise
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrieved!");

                Console.WriteLine("Employee Name: {0}", result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist.");
            }

            Console.WriteLine(Convert(5));
        }

        public static string Convert(int i)
        {
            // TODO
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };

            if (myDictionary.ContainsKey(i))
                return myDictionary[i];
            else
                return "nope";
        }
    }

    class Employee
    {
        // properties Role, Name, Age, and Rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // yearly salary = rate/h * number of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // simple constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}