using System.Collections.Generic;

namespace ChicagoCardGame
{
    public interface IDeckOfCards
    {
        void Shuffle();
        List<Card> DrawHand(int cardsInHand);
    }
}