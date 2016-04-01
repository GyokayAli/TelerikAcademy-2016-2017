/*Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program that prints the visible characters of the ASCII table on the console 
 * (characters from 33 to 126 including).*/

using System;

namespace _14.PrintASCIITable
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            for (int i = 33; i < 127; i++)
            {
                Console.Write((char)i);
            }
        }
    }
}
