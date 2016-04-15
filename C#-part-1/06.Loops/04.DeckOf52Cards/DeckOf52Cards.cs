/*Problem 4. Print a Deck of 52 Cards

Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck 
of 52 cards up to the card with the given sign(without the jokers).The cards should be printed using the classical notation 
(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
*/
using System;
class DeckOf52Cards
{
    static void Main()
    {
        string n = Console.ReadLine();
        int count = Convert.ToInt32(n);
        string j = "J";
        string q = "Q";
        string k = "K";
        string a = "A";

        for (int i = 2; i <= count; i++)
        {
            if (i <= 10)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
            if (i == 11)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", j);
            }
            if (i == 12)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", q);
            }
            if (i == 13)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", k);
            }
            if (i == 14)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
            }
            else if (i > 14)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
            }
        }
    }
}
