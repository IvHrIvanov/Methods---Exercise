using System;

namespace _06._Middle_Characters
{
    class Program
    {
        private const int Length = 1;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string export;
            if (input.Length % 2 == 0)
            {                             
                string outputToMethod = SubstringEvenSubstractSymbols(input);
                export = outputToMethod;
            }
            else
            {
                string outputOddMethod = SubtrinsOddSubstractSymbol(input);
                export = outputOddMethod;
            }
            Console.WriteLine(export);
        }

        private static string SubtrinsOddSubstractSymbol(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index,1);
            return chars;
        }

        private static string SubstringEvenSubstractSymbols(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index-1,2);
            return chars;

        }
    }
}
