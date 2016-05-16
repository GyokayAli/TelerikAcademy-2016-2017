//Write a program that reads 3 real numbers from the console and prints their sum.
using System;
using System.Linq;

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3]; //get 3 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
