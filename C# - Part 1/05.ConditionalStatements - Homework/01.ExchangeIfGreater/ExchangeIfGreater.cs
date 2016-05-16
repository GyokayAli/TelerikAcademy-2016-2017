/*Write a program that reads two double values from the console A and B, 
 * stores them in variables and exchanges their values if the first one is greater 
 * than the second one. Use an if-statement. As a result print the values of the variables A and B, 
 * separated by a space.*/

using System;
using System.Linq;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[2]; //get 2 inputs from the user

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine("{0} {1}", numbers[1],numbers[0]);
            }
            else if (numbers[0] < numbers[1])
            {
                Console.WriteLine("{0} {1}", numbers[0], numbers[1]);
            }
            else
            {
                Console.WriteLine("{0} {1}", numbers[0], numbers[1]);
            }
        }
    }
}
