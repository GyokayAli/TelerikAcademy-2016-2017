/*Write a program that gets two numbers from the console and prints the greater of them.*/

using System;
using System.Linq;

namespace _05.NumbersComparer
{
    class NumbersComparer
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[2]; //get 2 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(numbers.Max());
        }
    }
}
