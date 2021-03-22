using System;
using System.Collections.Generic;
using System.Linq;
using ChicagoCardGame.Enums;

namespace ChicagoCardGame
{

    public class CardDeck : IDeckOfCards
    {
        private List<Card> _cards;

        public CardDeck()
        {
            _cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (var i = 1; i <= 13; i++)
                {
                    _cards.Add(new Card
                    {
                        Suit = suit,
                        Value = i
                    });
                }
            }
        }

        public void Shuffle()
        {
            _cards = _cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public List<Card> DrawHand(int numberOfCards)
        {
            return _cards.Take(numberOfCards).ToList();
        }
    }
}