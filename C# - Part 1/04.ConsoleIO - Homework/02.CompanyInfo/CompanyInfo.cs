/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

namespace _02.CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string[] info = new string[9]; //get 9 inputs from the user

            for (int i = 0; i < info.Length; i++)
            {
                info[i] = Console.ReadLine();
            }
            Console.WriteLine(@"
{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})", info[0], info[1], info[2], 
 info[3].Length > 0 ? info[3] : "(no fax)", 
 info[4], info[5], info[6], info[7], info[8]);
        }
    }
}
