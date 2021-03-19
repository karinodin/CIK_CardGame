using System.Linq;

namespace ChicagoCardGame.Rules
{
    public class FlushRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var suit = hand.CardsInHand.First().Suit;
            foreach (Card card in hand.CardsInHand)
            {
                if (card.Suit != suit)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class StraightRule : IRule
    {
        public bool ValidateRule(Hand hand)
        {
            var sortedHand = hand.CardsInHand.OrderBy(x => x.Value);
            var currentValue = sortedHand.First().Value;

            var first = true;
            foreach (Card card in sortedHand)
            {
                if (first == false)
                {
                    if (card.Value - currentValue != 1)
                    {
                        return false;
                    }
                }
                first = false;
                currentValue = card.Value;
            }

            return true;
        }
    }
}