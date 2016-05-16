/*Write a program that, depending on the first line of the input, reads an int, double or string variable.

If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
 */

using System;

namespace _09.IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();
            string output = "";
            switch (type)
            {
                case "integer":
                    output = string.Format("{0}", int.Parse(value) + 1);
                    break;
                case "real":
                    output = string.Format("{0:F2}", double.Parse(value) + 1);
                    break;

                case "text":
                    output = string.Format("{0}*", value);
                    break;
            }
            Console.WriteLine(output);
        }
    }
}
