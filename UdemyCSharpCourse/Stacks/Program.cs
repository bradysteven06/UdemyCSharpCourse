using System;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using Push()
            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(4);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(5);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(6);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(7);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            while (stack.Count > 0)
            {
                int myStackItem = stack.Pop();
                Console.WriteLine("Popped item is: {0}", myStackItem);
                if (stack.Count > 0)
                {
                    Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
                }
            }
            Console.WriteLine("The number of items left in the stack is: {0}", stack.Count);

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2, 5, 20, 15 };
            Stack<int> numStack = new Stack<int>();

            foreach (int number in numbers)
            {
                numStack.Push(number);
                Console.WriteLine("Top value in the stack is: {0}", numStack.Peek());
            }

            while (numStack.Count > 0)
            {
                Console.WriteLine(numStack.Pop() + " ");
            }
        }
    }
}