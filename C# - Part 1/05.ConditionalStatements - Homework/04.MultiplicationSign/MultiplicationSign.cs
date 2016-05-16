/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.*/

using System;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3]; //get 3 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double product = numbers[0] * numbers[1] * numbers[2];

            if (product > 0)
                Console.WriteLine("+");
            else if (product == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("-");
        }
    }
}
