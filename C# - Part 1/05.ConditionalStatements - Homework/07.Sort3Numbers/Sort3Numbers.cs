//Write a program that enters 3 real numbers and prints them sorted in descending order.

using System;
using System.Linq;

namespace _07.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = numbers.OrderByDescending(c => c).ToArray();

            Console.WriteLine("{0} {1} {2}",numbers[0],numbers[1],numbers[2]);
        }
    }
}