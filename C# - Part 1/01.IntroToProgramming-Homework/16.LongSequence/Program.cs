using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            int num = 2;
            while (num <= 1001)
            {
                if (num % 2 != 0) //check if Odd
                    Console.WriteLine("-" + num++);
                else
                    Console.WriteLine(num++);
            }
        }
    }
}
