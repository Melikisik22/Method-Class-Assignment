using System;

namespace MathOperationApp
{
    class MathOperations
    {
        public void DoMath(int number1, int number2)
        {
            int result = number1 * 2;

            Console.WriteLine("Result of math operation on first number: " + result);

            Console.WriteLine("Second number passed into the method: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            math.DoMath(5, 20);

            math.DoMath(number1: 10, number2: 50);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
