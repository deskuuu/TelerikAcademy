using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardFace_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var cardFace = card.Face;
        }

        [TestMethod]
        public void TestCardSuit_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var cardFace = card.Suit;
        }

        [TestMethod]
        public void TestCreateCard_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDifferentCard_ShouldNotBePassed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            Card.GetDifferentCards(card, card);
        }

        [TestMethod]
        public void TestDifferentCard_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var diffCard = new Card(CardFace.Eight, CardSuit.Diamonds);
            Card.GetDifferentCards(card, diffCard);
        }

        [TestMethod]
        public void TestToString_ShouldBeSuccessed()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            string cardString = card.ToString();
            Assert.AreEqual("Ace : Clubs", cardString);
        }
    }
}
