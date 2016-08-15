using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public const int MaxCardsInHand = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Invaid hand");
            }

            if (hand.Cards.Count != MaxCardsInHand)
            {
                throw new IndexOutOfRangeException("Cards must be 5.");
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        { 
            var group = hand.Cards.GroupBy(card => card.Suit);

            return group.Any(gr => gr.Count() == 5);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var group = hand.Cards.GroupBy(card => card.Face);

            return group.Any(gr => gr.Count() == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            var groupThree = hand.Cards.GroupBy(card => card.Face);
            var groupTwo = hand.Cards.GroupBy(card => card.Face);
            var isFullHouse= groupThree.Any(gr => gr.Count() == 3) && groupTwo.Any(gr => gr.Count() == 2);

            if (!isFullHouse)
            {
                throw new ArgumentException("This is not a full house.");
            }

            return isFullHouse;
        }

        public bool IsFlush(IHand hand)
        {
            var isFlush = true;
            var group = hand.Cards.GroupBy(card => card.Suit);
            isFlush= group.Any(gr => gr.Count() == 5); 

            if (!isFlush)
            {
                throw new ArgumentException("Invalid flush.");
            }

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            var isThreeOfAKind = true;
            var group = hand.Cards.GroupBy(card => card.Face);
            isThreeOfAKind = group.Any(gr => gr.Count() == 3);

            if (!isThreeOfAKind)
            {
                throw new ArgumentException("Invalid cards.");
            }

            return isThreeOfAKind;
        }

        public bool IsTwoPair(IHand hand)
        {
            var isTwoPair= false;
            var firstTwo = false;
            var secondTwo = false;

            var group = hand.Cards.GroupBy(card => card.Face);
            firstTwo = group.Any(gr => gr.Count() == 2);

            // ToDo: secondTwo cheker

            if (!isTwoPair)
            {
                throw new ArgumentException("Invalid flush.");
            }

            return isTwoPair = firstTwo && secondTwo;
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            if (firstHand == null)
            {
                throw new ArgumentNullException("Invalid hand");
            }

            if (secondHand == null)
            {
                throw new ArgumentNullException("Invalid hand");
            }

            return 1;
        }
    }
}
