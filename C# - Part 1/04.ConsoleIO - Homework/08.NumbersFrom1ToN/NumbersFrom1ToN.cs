﻿/*Write a program that reads an integer number N from the console and 
 * prints all the numbers in the interval [1, n], each on a single line.*/

using System;

namespace _08.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++ )
            {
                Console.WriteLine(i);
            }
        }
    }
}
