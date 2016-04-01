/*Reads an integer number from the console.
 Stores in a variable if the number can be divided by 7 and 5 without remainder.
 Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
 Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.*/
using System;

namespace _03.DivideBy7and5
{
    class DivideBy7and5
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string isTrue = (num % 7 == 0 && num % 5 == 0) ? "true" : "false";

            Console.WriteLine(isTrue + " " + num);
        }
    }
}
