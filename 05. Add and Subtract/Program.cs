using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            int thirdInput = int.Parse(Console.ReadLine());

            int sum = Sum(input, secondInput, thirdInput);

            Console.WriteLine(sum);
        }

        private static int Sum(int input, int secondInput, int thirdInput)
        {
            int firstSum = input + secondInput;
            int substracion = firstSum - thirdInput;

            return substracion;
        }
    }
}