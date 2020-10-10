using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            Print(input);

        }

        private static void Print(int input)
        {
            for (int i = 0; i < input; i++)
            {
                bool isOddDigit = false;
                string currentNumber = i.ToString();
                int sumOfDigits = 0;
                foreach (var current in currentNumber)
                {
                    int parseNumber = (int)current;
                    if (parseNumber % 2 == 1)
                    {
                        isOddDigit = true;
                    }

                    sumOfDigits += parseNumber;
                }
                if (sumOfDigits % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}