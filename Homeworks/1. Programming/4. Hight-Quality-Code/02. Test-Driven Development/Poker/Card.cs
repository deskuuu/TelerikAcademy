using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public static void GetDifferentCards(ICard one, ICard two)
        {
            if (one == two)
            {
                throw new ArgumentException("Cards cannot be the same.");
            }

            if (!(one == two))
            {
                Console.WriteLine($"Tha card {one} is not the same as {two}.");
            }
        }

        public override string ToString()
        {
            return String.Format($"{this.Face} : {this.Suit}");
        }
    }
}
