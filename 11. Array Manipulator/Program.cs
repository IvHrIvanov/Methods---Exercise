using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            string[] manipulation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (manipulation[0] != "end")
            {
                string output = string.Empty;


                if (manipulation.Length == 2)
                {
                    string evenOrOddManipulation = manipulation[0] + " " + manipulation[1];


                    if (manipulation[0] == "exchange")
                    {
                        int index = int.Parse(manipulation[1]);


                        if (index >= 0 && index <= input.Length - 1)
                        {
                            ToMethodExnahge(index, input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                    }

                    else if (evenOrOddManipulation == "max" + " " + "odd")
                    {

                        MaxOddMethod(input);

                    }
                    else if (evenOrOddManipulation == "max" + " " + "even")
                    {

                        MaxEvenMethod(input);

                    }

                    else if (evenOrOddManipulation == "min" + " " + "odd")
                    {

                        MinOddMethod(input);

                    }

                    else if (evenOrOddManipulation == "min" + " " + "even")
                    {
                        MinEvenMethod(input);

                    }
                }
                else if (manipulation.Length == 3)
                {
                    int manipulationChek = int.Parse(manipulation[1]);

                    if (manipulationChek > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        string firstLastCount = manipulation[0] + " " + manipulation[1] + " " + manipulation[2];

                        if (firstLastCount == "first" + " " + manipulation[1] + " " + "even")
                        {
                            FirstMarkEvenNumbers(input, manipulation[1]);
                        }
                        else if (firstLastCount == "first" + " " + manipulation[1] + " " + "odd")
                        {
                            FirstMarkOddNumber(input, manipulation[1]);
                        }
                        else if (firstLastCount == "last" + " " + manipulation[1] + " " + "odd")
                        {
                            LastMarkOddNumber(input, manipulation[1]);
                        }
                        else if (firstLastCount == "last" + " " + manipulation[1] + " " + "even")
                        {
                            LastMarkEvenNumber(input, manipulation[1]);
                        }
                    }
                }

                manipulation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (manipulation[0] == "end")
            {
                Console.WriteLine($"[{string.Join(", ", input)}]");
            }

        }

        private static void LastMarkEvenNumber(int[] input, string manipulation)
        {
            int command = int.Parse(manipulation);
            int[] lastEvenNumber = new int[input.Length];
            int count = 0;
            int zeroDigit = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 == 0)
                {
                    if (input[i] == 0)
                    {
                        zeroDigit++;
                    }

                    lastEvenNumber[count] = input[i];
                    count++;

                    if (count == command)
                    {
                        break;
                    }
                }

            }
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                int counterZero = 0 - zeroDigit;
                for (int i = 0; i < lastEvenNumber.Length; i++)
                {
                    if (lastEvenNumber[i] == 0)
                    {
                        counterZero++;
                    }

                }
                int[] finalCheckFirstEven = new int[lastEvenNumber.Length - counterZero];
                for (int i = 0; i < finalCheckFirstEven.Length; i++)
                {
                    finalCheckFirstEven[i] = lastEvenNumber[i];
                }
                lastEvenNumber = finalCheckFirstEven;
                Console.WriteLine($"[{string.Join(", ", lastEvenNumber)}]");
            }
        }

        private static void LastMarkOddNumber(int[] input, string manipulation)
        {
            int command = int.Parse(manipulation);                       
            int max = 0;         
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]%2!=0)
                {
                    max++;
                }
            }
            int[] maxOdd = new int[max];
            max = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]%2!=0)
                {
                    maxOdd[max] = input[i];
                    max++;
                }
            }

           if(command>=maxOdd.Length)
            {
                Console.WriteLine($"[{string.Join(", ", maxOdd)}]");
            }
            else
            {
                int[] temp = new int[command];
                for (int i = 0; i < command; i++)
                {
                    temp[i] = maxOdd[maxOdd.Length - command + i];
                }
                PrintArrayWithoutZero(temp);
            }
        }
        private static void FirstMarkOddNumber(int[] input, string manipulation)
        {

            int count = 0;
            int command = int.Parse(manipulation);
            int[] firstOdd = new int[command];
            int zeroDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {

                    if (input[i] == 0)
                    {
                        zeroDigit++;
                    }

                    firstOdd[count] = input[i];
                    count++;

                    if (count >= command)
                    {
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                PrintArrayWithoutZero(firstOdd);
            }
        }

        private static void FirstMarkEvenNumbers(int[] input, string manipulation)
        {
            int count = 0;
            int command = int.Parse(manipulation);
            int[] firstEven = new int[input.Length];
            int zeroDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {

                    if (input[i] == 0)
                    {
                        zeroDigit++;
                    }

                    firstEven[count] = input[i];
                    count++;

                    if (count >= command)
                    {
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                int counterZero = 0 - zeroDigit;
                for (int i = 0; i < firstEven.Length; i++)
                {
                    if (firstEven[i] == 0)
                    {
                        counterZero++;
                    }

                }
                int[] finalCheckFirstEven = new int[firstEven.Length - counterZero];
                for (int i = 0; i < finalCheckFirstEven.Length; i++)
                {
                    finalCheckFirstEven[i] = firstEven[i];
                }
                firstEven = finalCheckFirstEven;
                Console.WriteLine($"[{string.Join(", ", firstEven)}]");

            }

        }

        static void MinEvenMethod(int[] input)
        {
            int minEvenNumber = int.MaxValue;
            int minEvenInAray = 0;
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (minEvenNumber >= input[i])
                    {
                        minEvenNumber = input[i];
                        minEvenInAray = i;
                        flag = false;
                    }
                }

            }

            if (flag)
            {

                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(minEvenInAray);
            }
        }

        static void MinOddMethod(int[] input)
        {
            int minOddNumber = int.MaxValue;
            int minOddInArray = 0;
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    if (minOddNumber >= input[i])
                    {
                        minOddNumber = input[i];
                        minOddInArray = i;
                        flag = false;
                    }
                }

            }
            if (flag)
            {

                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(minOddInArray);
            }

        }

        static void MaxEvenMethod(int[] input)
        {
            int maxEvenNumber = int.MinValue;
            int bigEvenInArray = 0;
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (maxEvenNumber <= input[i])
                    {
                        maxEvenNumber = input[i];
                        bigEvenInArray = i;
                        flag = false;
                    }
                }

            }
            if (flag)
            {

                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(bigEvenInArray);
            }


        }

        static void MaxOddMethod(int[] input)
        {
            int maxOddNumber = int.MinValue;
            int maxOddInArray = 0;
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    if (maxOddNumber <= input[i])
                    {
                        maxOddNumber = input[i];
                        maxOddInArray = i;
                        flag = false;
                    }
                }

            }
            if (flag)
            {

                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(maxOddInArray);
            }


        }

        static int ToMethodExnahge(int index, int[] input)
        {
            int[] temp = new int[index + 1];

            for (int i = 0; i <= index; i++)
            {
                temp[i] = input[i];
            }

            for (int i = 0; i <= index; i++)
            {
                for (int k = 0; k < input.Length - 1; k++)
                {
                    input[k] = input[k + 1];
                }
            }
            int counter3 = 0;
            for (int i = input.Length - 1 - index; i < input.Length; i++)
            {
                input[i] = int.Parse(temp[counter3].ToString());
                counter3++;
            }
            return input[input.Length - 1];
        }
        private static void PrintArrayWithoutZero(int[] removeZero)
        {
            int counter = 0;

            for (int i = 0; i < removeZero.Length; i++)
            {
                if (removeZero[i] != 0)
                {
                    counter++;
                }
            }

            int[] newFirstOdd = new int[counter];
            int counterTwo = 0;
            for (int i = 0; i < removeZero.Length; i++)
            {
                if (removeZero[i] != 0)
                {
                    newFirstOdd[counterTwo] = removeZero[i];
                    counterTwo++;
                }
            }
            Console.WriteLine($"[{string.Join(", ", newFirstOdd)}]");
        }
    }
}