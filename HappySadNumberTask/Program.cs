using System;
using System.Collections.Generic;

namespace HappySadNumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsHappyNumber(number))
                {
                    Console.WriteLine($"{number} is a Happy number!");
                }
                else
                {
                    Console.WriteLine($"{number} is a Sad number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static bool IsHappyNumber(int num)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (num != 1 && !seenNumbers.Contains(num))
            {
                seenNumbers.Add(num);
                num = GetSumOfSquares(num);
            }

            return num == 1;
        }

        static int GetSumOfSquares(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }
    }
}
