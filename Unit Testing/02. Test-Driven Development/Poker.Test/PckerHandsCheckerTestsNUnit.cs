using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestFixture]
    public class PokerHandsCheckerTestsNUnit
    {
        [Test]
        public void CompareHands_TestForNullCards_ShouldNotBeCorrect()
        {
            IHand first = null;
            IHand second = null;
            var checker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => checker.CompareHands(first, second));
        }

        [Test]
        public void IsValidHand_TestForNullCards_ShouldNotBeCorrect()
        {
            IHand first = null;
            var checker = new PokerHandsChecker();

            Assert.Throws<ArgumentNullException>(() => checker.IsValidHand(first));
        }

        [Test]
        public void IsFourOfAKind_TestFourOfAKind_ShouldBeCorrect()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsStraightFlush_TestForStraightFlush_ShouldBeCorrect()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [Test]
        public void IsFullHouse_TestForFullHouse_ShouldThrowAnException()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            Assert.Throws<ArgumentException>(() => checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFlush_TestIsFlushWithDifferentCardsSuits_ShouldThrowAnException()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            Assert.Throws<ArgumentException>(() => checker.IsFlush(hand));
        }

        [Test]
        public void IsThreeOfAKind_TestForThreeOfAKind_ShouldThrowAnException()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            Assert.Throws<ArgumentException>(() => checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsTwoPair_TestForTwoPair_ShouldThrowAnException()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades)
            };
            var hand = new Hand(cards);

            Assert.Throws<ArgumentException>(() => checker.IsTwoPair(hand));
        }
    }
}
