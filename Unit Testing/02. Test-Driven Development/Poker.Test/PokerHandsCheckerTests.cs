using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareHands_TestForNullCards_ShouldNotBeCorrect()
        {
            IHand first = null;
            IHand second = null;
            var checker = new PokerHandsChecker();

            checker.CompareHands(first,second);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidHand_TestForNullCards_ShouldNotBeCorrect()
        {
            IHand first = null;
            var checker = new PokerHandsChecker();

            checker.IsValidHand(first);
        }

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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

            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
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

            Assert.IsFalse(checker.IsTwoPair(hand));
        }    
    }
}
