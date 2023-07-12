﻿namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a generic IEnumerable variable that takes any collection of type int
            // we will use this variable to store the collections that will get returned by the GetCollection() method
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            // foreach number in the collection we got back from GetCollection(1);
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // call GetCollection() with option = 2 which will return a Queue<int>
            // but we will store it in the base type of generic collections
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            // for each number in the colleciton we got back from GetCollection(2);
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            // call GetCollection() with option = 5 wich will return an array int[] but we will store it in the base type of generic collection
            unknownCollection = GetCollection(5);

            Console.WriteLine("This was an array of int");
            // for each number in the colleciton we got back from GetCollection(5);
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // create a list of numbers and initialize it
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            // add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                // return the list of type List<int>
                return numbersList;
            }
            else if (option == 2)
            {
                // return the queue of type<int>
                return numbersQueue;
            }
            else
            {
                // return an array of numbers initialized with some numbers
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}