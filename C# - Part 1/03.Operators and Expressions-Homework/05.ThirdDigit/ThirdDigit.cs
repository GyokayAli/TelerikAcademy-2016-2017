/*Write a program that reads an integer N from the console and prints true if the third digit of the N is 7,
  or "false THIRD_DIGIT", where you should print the third digits of N.
  The counting is done from right to left, meaning 123456's third digit is 4.*/

using System;

namespace _05.ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            string numStr = Console.ReadLine(); 

            int length = numStr.Length; //count digits in the number
            int digit = 0;

            if (3 <= length)
            {
                digit = (int)numStr[length - 3] - '0';
            }

            string isSeven = (digit == 7) ? "true" : "false " + digit;

            Console.WriteLine(isSeven);
        }
    }
}
