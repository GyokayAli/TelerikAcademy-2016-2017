/*Write a program that reads a number N and prints on the console the first N members 
 * of the Fibonacci sequence (at a single line, separated by comma 
 * and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. */

using System;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long a = 0;
            long b = 1;

            // Prints out the first number 0
            Console.Write(a);
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n - 1; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
                Console.Write(", " + a);
            }
        }
    }
}
