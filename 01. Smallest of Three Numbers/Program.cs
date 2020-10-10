using System;
using System.ComponentModel.DataAnnotations;

namespace _01_Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            int inputThree = int.Parse(Console.ReadLine());

            if (inputOne < inputTwo && inputOne < inputThree)
            {
                minNumber = inputOne;
            }
            else if (inputTwo < inputOne && inputTwo < inputThree)
            {
                minNumber = inputTwo;
            }
            else 
            {
                minNumber = inputThree;
            }
            Print(minNumber);
        }
        static void Print(int outputNumber)
        {
            Console.WriteLine(outputNumber);
        }
    }
}