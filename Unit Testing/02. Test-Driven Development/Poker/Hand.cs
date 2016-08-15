﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var stb = new StringBuilder();

            foreach(var card in this.Cards)
            {
                stb.Append($"Card: {card.Face} {card.Suit} ");
            }

            return stb.ToString();
        }
    }
}
