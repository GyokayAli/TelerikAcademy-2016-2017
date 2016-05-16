//Write a program that reads 5 integer numbers from the console and prints their sum.

using System;
using System.Linq;

namespace _07.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5]; //get 5 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
