using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            exportToMethod(input);
        }

        private static void exportToMethod(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int a = 0; a < input; a++)
                {
                    Console.Write(input + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
