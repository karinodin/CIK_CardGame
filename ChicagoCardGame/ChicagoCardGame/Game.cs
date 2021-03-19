using System.Collections.Generic;
using System.Linq;
using ChicagoCardGame.Rules;

namespace ChicagoCardGame
{
    public class Game
    {
        private readonly int _cardsInHand;
        private readonly List<IRule> _rules;

        public Game(int cardsInHand, List<IRule> rules)
        {
            _cardsInHand = cardsInHand;
            _rules = rules;
        }

        public int PlayGame()
        {
            var cardDeck = new CardDeck();
            var gameCompleted = false;
            var iterations = 0;

            while (!gameCompleted)
            {
                cardDeck.Shuffle();
                var myHand = new Hand(cardDeck.DrawHand(_cardsInHand));
                gameCompleted = CheckHand(myHand);

                iterations++;
            }

            return iterations;
        }

        private bool CheckHand(Hand hand)
        {
            foreach (var rule in _rules)
            {
                if (!rule.ValidateRule(hand))
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}