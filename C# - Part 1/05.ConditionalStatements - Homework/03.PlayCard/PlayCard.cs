/*Classical play cards use the following signs to designate the 
 * card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string and prints "yes CONTENT_OF_STRING" 
 * if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
 */
using System;

namespace _03.PlayCard
{
    class PlayCard
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            bool inDeck = false;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == sign)
                {
                    inDeck = true;
                }
            }
            Console.WriteLine((inDeck ? "yes " : "no ") + sign);
        }
    }
}
