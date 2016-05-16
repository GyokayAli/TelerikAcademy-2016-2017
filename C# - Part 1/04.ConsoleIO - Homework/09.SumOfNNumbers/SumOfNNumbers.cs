/*Write a program that enters a number N and after that enters 
 * more N numbers and calculates and prints their sum. */

using System;
using System.Linq;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n]; //get 3 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
