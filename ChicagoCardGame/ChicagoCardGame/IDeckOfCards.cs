using System.Collections.Generic;

namespace ChicagoCardGame
{
    public interface IDeckOfCards
    {
        public void Shuffle();
        public List<Card> DrawHand(int cardsInHand);
    }
}