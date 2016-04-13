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
        string j = "J";
        string q = "Q";
        string k = "K";
        string a = "A";

        for (int i = 2; i < 11; i++)
        {
            Console.WriteLine(" {0} of spades, {0} of clubs, {0} of hearts, {0} of dimonds", i);
        }
         
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine(" {0} of spades, {0} of clubs, {0} of hearts, {0} of dimonds", j);
            Console.WriteLine(" {0} of spades, {0} of clubs, {0} of hearts, {0} of dimonds", q);
            Console.WriteLine(" {0} of spades, {0} of clubs, {0} of hearts, {0} of dimonds", k);
            Console.WriteLine(" {0} of spades, {0} of clubs, {0} of hearts, {0} of dimonds", a);
        }
    }
}
