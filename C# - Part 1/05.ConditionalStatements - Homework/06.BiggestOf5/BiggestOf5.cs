//Write a program that finds the biggest of five numbers that are read from the console.

using System;
using System.Linq;

namespace _05.BiggestOf5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5]; //get 5 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
