/*Write a program that reads an integer N (which will always be less than 100 or equal) 
  and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).*/
using System;

namespace _08.PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (num == 1 || num <= 0)
                isPrime = false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "true" : "false");
        }
    }
}
