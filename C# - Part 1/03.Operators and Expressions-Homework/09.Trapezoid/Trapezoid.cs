/*Write an expression that calculates trapezoid's area by given sides a and b and height h. 
 The three values should be read from the console in the order shown below. All three value will be floating-point numbers.*/

using System;

namespace _09.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal area = ((a + b) / 2) * h; //area of trapezoid

            Console.WriteLine(string.Format("{0:F7}", area));
        }
    }
}
