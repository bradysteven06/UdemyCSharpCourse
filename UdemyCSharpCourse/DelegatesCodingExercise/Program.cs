namespace DelegatesCodingExercise
{
    internal class Program
    {
        public delegate float OperationDelegate(float num1, float num2);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public static float ApplyOperation(float num1, float num2, OperationDelegate oper)
        {
            float result;
            result = oper(num1, num2);
            return result;
        }
     }
}