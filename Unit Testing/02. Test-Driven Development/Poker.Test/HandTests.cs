using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace Poker.Test
{
    [TestFixture]
    class HandTests
    {
        [Test]
        public void ReturnToString_ShouldBeSuccessed()
        {
            var cards = new List<ICard>
            {
                new Card(CardFace.Eight,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Diamonds)
            };

            var hand = new Hand(cards);
            var expected = "Card: Eight Clubs Card: Five Diamonds ";

            Assert.AreEqual(expected, hand.ToString());
        }
    }
}
