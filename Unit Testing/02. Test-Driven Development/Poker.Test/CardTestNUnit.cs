using System;
using NUnit.Framework;

namespace Poker.Test
{
    [TestFixture]
    class CardTestNUnit
    {
        [Test]
        public void TestCardFace_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var cardFace = card.Face;
        }

        [Test]
        public void TestCardSuit_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var cardFace = card.Suit;
        }

        [Test]
        public void TestCreateCard_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
        }

        [Test]
        public void TestDifferentCard_ShouldNotBePassed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            Assert.Throws<ArgumentException>(() => Card.GetDifferentCards(card, card));
        }

        [Test]
        public void TestDifferentCard_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var diffCard = new Card(CardFace.Eight, CardSuit.Diamonds);
            Card.GetDifferentCards(card, diffCard);
        }

        [Test]
        public void TestToString_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            string cardString = card.ToString();
            Assert.AreEqual("Ace : Clubs", cardString);
        }
    }
}
