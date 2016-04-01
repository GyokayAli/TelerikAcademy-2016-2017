/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of 
 * given 32-bit unsigned integer(read from the console).
 * 
 * On the only input line you will receive the unsigned integer number whose bits you must exchange.
 * On the only output line print the value of the integer with the exchanged bits.*/
using System;

namespace _14.BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int pos1 = 3;
            int pos2 = 24;

            int mask1 = 7 << pos1;
            int mask2 = 7 << pos2;

            int numAndMask1 = num & mask1;
            int numAndMask2 = num & mask2;

            int change = (num & ~mask1) & ~mask2;

            int mask3 = (numAndMask1 >> pos1) << pos2;
            int mask4 = (numAndMask2 >> pos2) << pos1;

            int result = (change | mask3) | mask4;

            Console.WriteLine(result);
        }
    }
}
