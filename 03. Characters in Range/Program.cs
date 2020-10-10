using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string secondInput = Console.ReadLine();

            char firstChar = input[0];
            char secondChar = secondInput[0];

            Print(firstChar, secondChar);

        }
        static void Print(char firstChar, char secondChar)
        {
            int firstRow = (int)firstChar;
            int secondRow = (int)secondChar;

            if (firstChar > secondChar)
            {
                firstRow = secondChar;
                secondRow = firstChar;
            }

            for (int i = firstRow + 1; i < secondRow; i++)
            {
                char output = (char)i;
                Console.Write(output + " ");
            }
        }
    }
}