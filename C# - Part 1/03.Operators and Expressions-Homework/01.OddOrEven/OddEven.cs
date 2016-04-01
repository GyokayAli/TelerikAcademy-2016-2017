/*Write a program that reads an integer from the console, 
 * uses an expression to check if given integer is odd or even, 
 * and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.*/
using System;

namespace _01.OddOrEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //cast to integer

            string oddOrEven = "odd";

            if (num % 2 == 0) oddOrEven = "even";

            Console.WriteLine(oddOrEven + " " + num);
        }
    }
}
