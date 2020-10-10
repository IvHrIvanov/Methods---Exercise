using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string falseOrtrue = string.Empty;
            while (input != "END")
            {
                string output = toMethod(input);
                if(input==output)
                {
                    falseOrtrue = "true";
                }
                else
                {
                    falseOrtrue = "false";
                }
                Console.WriteLine(falseOrtrue);
                input = Console.ReadLine();
                
            }
        }

        private static string toMethod(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
    }
}