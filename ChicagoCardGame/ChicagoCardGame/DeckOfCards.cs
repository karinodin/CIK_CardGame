using System;
using System.Collections.Generic;
using System.Linq;
using ChicagoCardGame.Enums;

namespace ChicagoCardGame
{

    public class CardDeck : IDeckOfCards
    {
        private List<Card> Cards { get; set; }

        public CardDeck()
        {
            Cards = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (var i = 1; i <= 13; i++)
                {
                    Cards.Add(new Card
                    {
                        Suit = suit,
                        Value = i
                    });
                }
            }
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public List<Card> DrawHand(int numberOfCards)
        {
            return Cards.Take(numberOfCards).ToList();
        }
    }
}