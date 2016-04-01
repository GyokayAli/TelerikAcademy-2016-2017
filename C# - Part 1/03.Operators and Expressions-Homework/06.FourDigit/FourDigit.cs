/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 1: Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
 2: Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
 3: Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
 4: Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.*/

using System;
using System.Linq;

namespace _06.FourDigit
{
    class FourDigit
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().ToCharArray().Select(x => Int32.Parse(x.ToString())).ToArray();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", Sum(digits),
                                                    ReverseNum(digits), 
                                                    LastDigitFirst(digits),
                                                    ExchangeDigits(digits));
        }
        
        //calculate the sum
        private static int Sum(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum;
        }

        //numbers in reversed order
        private static string ReverseNum(int[] digits)
        {
            string reverse = string.Join("", digits.Reverse());
            return reverse;
        }

        //reposition digits in a number
        private static string LastDigitFirst(int[] digits)
        {
            string lastDigitFirst = "" + digits[digits.Length - 1];
            for (int i = 0; i < digits.Length - 1; i++)
            {
                lastDigitFirst += digits[i];
            }
            return lastDigitFirst;
        }

        //reposition digits in a number
        private static string ExchangeDigits(int[] digits)
        {
            return digits[0].ToString() + digits[2] + digits[1] + digits[3]; 
        }
    }
}
