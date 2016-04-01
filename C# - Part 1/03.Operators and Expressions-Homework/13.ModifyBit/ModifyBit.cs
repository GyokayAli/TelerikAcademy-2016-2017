/*We are given an integer number N(read from the console), a bit value v(read from the console as well) 
 * (v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of C# code) 
 * that modifies N to hold the value v at the position P from the binary representation of N while preserving all
 * other bits in N. Print the resulting number on the console.
 
 * The input will consist of exactly 3 lines containing the following:
 * First line - the integer number N.
 * Second line - the position P.
 * Third line - the bit value v*/
using System;

namespace _13.ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            int val = int.Parse(Console.ReadLine());

            if (((num >> pos) & 1) != val)
                num ^= (1 << pos);

            Console.WriteLine(num);
        }
    }
}
