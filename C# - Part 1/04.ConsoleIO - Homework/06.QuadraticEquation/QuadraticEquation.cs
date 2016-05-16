/*Write a program that reads the coefficients a, b and c of a quadratic equation
 * ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3]; //get 3 inputs from the user (a,b and c)

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double a = numbers[0];
            double b = numbers[1];
            double c = numbers[2];

            var root = b * b - 4 * a * c;
            if (root < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double x1 = ((-1) * b - Math.Sqrt(root)) / (2 * a);
                double x2 = ((-1) * b + Math.Sqrt(root)) / (2 * a);

                if (x1 == x2)
                    Console.WriteLine(string.Format("{0:F2}",x1));
                else
                    Console.WriteLine("{0}\n{1}", string.Format("{0:F2}",x1), string.Format("{0:F2}",x2));
            }
        }
    }
}
