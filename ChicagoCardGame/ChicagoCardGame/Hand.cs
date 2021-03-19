using System.Collections.Generic;

namespace ChicagoCardGame
{
    public class Hand
    {
        public readonly List<Card> CardsInHand;

        public Hand(List<Card> cards)
        {
            CardsInHand = cards;
        }
    }
}