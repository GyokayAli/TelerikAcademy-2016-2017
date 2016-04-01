/*The gravitational field of the Moon is approximately 17% of that on the Earth.
 Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
 The weight W should be read from the console.
 
 The input will consist of a single line containing a single floating-point number - the weight W.
 
 Output a single floating-point value - how much a man with the weight W on Earth will weigh on the Moon. 
 Output all values with exactly 3-digit precision after the floating point.
 Hint: You can use the built-in .NET functionality*/

using System;

namespace _02.MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            float weightOnEarth = float.Parse(Console.ReadLine()); //get weight of man
            float moonGravity = 0.17f; // %17

            float weightOnMoon = weightOnEarth * moonGravity;

            Console.WriteLine(string.Format("{0:F3}", weightOnMoon));
        }
    }
}
