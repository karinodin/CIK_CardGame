using System.Collections.Generic;

namespace ChicagoCardGame
{
    public class Hand
    {
        public List<Card> CardsInHand;

        public Hand(List<Card> cards)
        {
            CardsInHand = cards;
        }
    }
}