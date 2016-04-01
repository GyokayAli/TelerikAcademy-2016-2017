/*Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
  The bits are counted from right to left, starting from bit 0.
  The result of the expression should be either 1 or 0. Print it on the console.*/
using System;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int pos = 3;
            int mask = 1 << pos;
            int numberAndmask = num & mask;
            int bit = numberAndmask >> pos;

            Console.WriteLine(bit);
        }
    }
}
