using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.AgeAfter10Years
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            //365 for the days in a year. +0.25 for leap years. +0.005 for other corrections 
            int age = (int)((DateTime.Now - dateOfBirth).TotalDays / 365.242199);

            Console.WriteLine(age); // age now
            Console.WriteLine(age+10); // age after 10 years
        }
    }
}
