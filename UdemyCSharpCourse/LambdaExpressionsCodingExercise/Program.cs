using System;

namespace LambdaExpressionsCodingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define numbers and operator
            float num1 = 10;
            float num2 = 2;
            string operatorSymbol = "+";

            // get the operation
            Func<float, float, float> operation = OperationGet(operatorSymbol);

            // perform the operation and print the result
            if (operation != null)
            {
                float result = operation(num1, num2);
                Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Invalid operation symbol");
            }
        }

        static Func<float, float, float> Plus = (num1, num2) => num1 + num2;
        static Func<float, float, float> Minus = (num1, num2) => num1 - num2;
        static Func<float, float, float> Divide = (num1, num2) => num1 / num2;
        static Func<float, float, float> Multiply = (num1, num2) => num1 * num2;
        static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            {"+", Plus},
            {"-", Minus},
            {"/", Divide},
            {"*", Multiply},
        };

        public static Func<float, float, float>OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }
    }
}