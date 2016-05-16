/*Write a program that reads from the console the radius r of a circle and prints 
 * its perimeter and area, rounded and formatted with 2 digits after the decimal point. */

using System;

namespace _03.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine()); //get radius

            double perimeter = 2 * Math.PI * radius; //perimeter of circle
            double area = Math.PI * Math.Pow(radius, 2); //area of circle

            Console.WriteLine("{0} {1}", string.Format("{0:F2}", perimeter), string.Format("{0:F2}", area));
        }
    }
}
