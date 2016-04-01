//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
/* Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
 * floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

namespace _13.ComparingFloats
{
    class CompareFloats
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()); //get floating point number 1

            double b = Convert.ToDouble(Console.ReadLine()); //get floating point number 2

            bool preciseEqual = Math.Abs(a - b) < 0.000001; //check if equal

            Console.WriteLine(preciseEqual ? "true" : "false");
        }
    }
}
