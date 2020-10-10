using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] outputMessage = { "Password must be between 6 and 10 characters",
                "Password must consist only of letters and digits",
            "Password must have at least 2 digits"};

            char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Print(input, outputMessage, number);

        }
        static void Print(string input,
                          string[] outputMassage,
                          char[] number)
        {

            int digits = 0;
            int passConfirm = 0;
            bool flag = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int a = 0; a < number.Length; a++)
                {
                    if (input[i] == number[a])
                    {
                        digits++;
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] >= 65 && input[i] <= 90 || input[i] >= 48 && input[i] <= 57)
                {
                    flag = false;
                }
                else if (input[i] >= 97 && input[i] <= 122)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                    break;
                }

            }

            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine(outputMassage[0]);
            }
            else
            {
                passConfirm++;
            }

            if (flag)
            {
                Console.WriteLine(outputMassage[1]);
            }
            else
            {
                passConfirm++;
            }

            if (digits < 2)
            {
                Console.WriteLine(outputMassage[2]);
            }
            else
            {
                passConfirm++;
            }

            if (passConfirm == 3)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}