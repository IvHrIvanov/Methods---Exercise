using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            int sum = outputToMethod(input, secondInput);

            Console.WriteLine($"{sum/secondInput*1.0:f2}");

        }

        private static int outputToMethod(int input, int secondInput)
        {
            int result = 1;

            while (input != 1)
            {

                result = result * input;

                input = input - 1;

            }

            return result;
        }
    }
}