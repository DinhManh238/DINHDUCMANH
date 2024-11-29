using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DINHDUCMANH
{
    internal class Session_04
    {



        /* 1. Write a C# function to find the maximum of three numbers.- Improve the next version that accept at least 1 parameter.
2. Write a C# function to calculate the factorial of a number (a non-negative 
integer). The function accepts the number as an argument.
3. Write a C# function that takes a number as a parameter and checks whether 
the number is prime or not.
4. Write a C# function to print 
1. all prime numbers that less than a number (enter prompt keyboard).
2. the first N prime numbers
5. Write a C# function to check whether a number is "Perfect" or not. Then print 
all perfect number that less than 1000.
6. Write a C# function to check whether a string is a pangram or not. */


        public static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static void Main(string[] args)
        {
            // Example usage
            int num1 = 10, num2 = 20, num3 = 15;
            int max = MaxOfThree(num1, num2, num3);

            Console.WriteLine($"The maximum of {num1}, {num2}, and {num3} is: {max}");
        }
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Number must be non-negative.");

            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static void PrintPrimesLessThan(int limit)
        {
            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void PrintFirstNPrimes(int n)
        {
            int count = 0, num = 2;
            while (count < n)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
        }

        public static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum == number;
        }

        public static void PrintPerfectNumbers()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i))
                    Console.WriteLine(i);
            }
        }



        public static bool IsPangram(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            input = input.ToLower();

            return alphabet.All(input.Contains);
        }


    }
}
