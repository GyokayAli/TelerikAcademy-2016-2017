using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int num = 2;
            while(num <= 11)
            {
                if(num % 2 != 0) //check if Odd
                    Console.WriteLine("-" + num++);
                else
                    Console.WriteLine(num++);
            }
        }
    }
}
