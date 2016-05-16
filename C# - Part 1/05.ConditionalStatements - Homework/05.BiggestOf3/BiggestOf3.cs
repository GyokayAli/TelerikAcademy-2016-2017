//Write a program that finds the biggest of three numbers that are read from the console.

using System;
using System.Linq;

namespace _05.BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3]; //get 3 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
