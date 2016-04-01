/*Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} 
 * with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.*
 * On the only four lines of the input you will receive the integers n, p, q and k in this order.
 * Output a single value - the value of n after the bit swaps.*/

using System;

namespace _15.BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int firstIndices = p, secondIndices = q, length = k;
                (firstIndices < 32 && secondIndices < 32) && length > 0;
                firstIndices++, secondIndices++, length--)
            {
                if (((n >> firstIndices) & 1) != ((n >> secondIndices) & 1))
                {
                    n = changeBits(n, firstIndices, secondIndices);
                }
            }
            Console.WriteLine(n);
        }

        private static int changeBits(int number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }       
    }
}
