namespace Deck.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void Deck_CheckCartsAfterInit_ShouldBe24()
        {
            var deck = new Deck();
            int cardsLeft = deck.CardsLeft;
            Assert.AreEqual(24, cardsLeft);
        }

        [Test]
        public void Deck_TakeNewCard_CheckIfNotNull()
        {
            var deck = new Deck();
            var card = deck.GetNextCard();
            Assert.AreNotEqual(null, card);
        }

        [Test]
        public void Deck_TakeNewCard_ShouldThrowExeption()
        {
            var deck = new Deck();
            for (int i = 1; i <= 24; i++)
            {
                var card = deck.GetNextCard();
            }
            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void Deck_TrumpCardChange_ShouldChangeTrump()
        {
            var deck = new Deck();
            var card = new Card(CardSuit.Club, CardType.Ace);
            deck.ChangeTrumpCard(card);
            Assert.AreEqual(card, deck.TrumpCard);
        }
    }
}