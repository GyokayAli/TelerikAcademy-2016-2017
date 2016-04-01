/*Write a program that reads from the console 
 two integer numbers P and N and prints on the console the value of P's N-th bit.*/
using System;

namespace _12.NthBit
{
    class NthBit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());

            int mask = 1 << pos;
            int numberAndmask = num & mask;
            int bit = numberAndmask >> pos;

            Console.WriteLine(bit);
        }
    }
}
