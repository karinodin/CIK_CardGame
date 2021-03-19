using System;
using System.Collections.Generic;
using System.Diagnostics;
using ChicagoCardGame.Rules;

namespace ChicagoCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardsInHand = 5;
            var straightFlushRule = new List<IRule>
            {
                new FlushRule(), new StraightRule()
            };

            var game = new Game(cardsInHand, straightFlushRule);

            game.PlayGame();

            var stopwatch = Stopwatch.StartNew();
            var tries = game.PlayGame();
            var elapsedTotalSeconds = stopwatch.Elapsed.TotalSeconds;
            var avg = tries / elapsedTotalSeconds;
            Console.Write($"Number of tries: {tries:N0} \nTime to complete rule:  {stopwatch.Elapsed} \nTries per second: {avg:N0}");

        }
    }
}