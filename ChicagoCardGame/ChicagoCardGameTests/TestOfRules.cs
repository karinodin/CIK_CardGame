using System.Collections.Generic;
using ChicagoCardGame;
using ChicagoCardGame.Enums;
using ChicagoCardGame.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChicagoCardGameTests
{
    [TestClass]
    public class TestOfRules
    {
        [TestInitialize]
        public void TestOfRulesFixture()
        {
            
        }
        
        [TestMethod]
        public void If_Flush_Rule_Fulfilled_Then_True_Is_Returned()
        {
            var rule = new FlushRule();

            var hand = new Hand(new List<Card>
            {
                new Card {Suit = Suit.Hearts, Value = 5},
                new Card {Suit = Suit.Hearts, Value = 7},
                new Card {Suit = Suit.Hearts, Value = 10},
                new Card {Suit = Suit.Hearts, Value = 11},
                new Card {Suit = Suit.Hearts, Value = 13}
            });
            
            var actual = rule.ValidateRule(hand);
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void If_Flush_Rule_Not_Fulfilled_Then_False_Is_Returned()
        {
            var rule = new FlushRule();

            var hand = new Hand(new List<Card>
            {
                new Card {Suit = Suit.Hearts, Value = 5},
                new Card {Suit = Suit.Spades, Value = 7},
                new Card {Suit = Suit.Hearts, Value = 10},
                new Card {Suit = Suit.Diamonds, Value = 11},
                new Card {Suit = Suit.Clubs, Value = 13}
            });
            
            var actual = rule.ValidateRule(hand);
            Assert.AreEqual(false, actual);
        }
        
        [TestMethod]
        public void If_Straight_Rule_Fulfilled_Then_True_Is_Returned()
        {
            var rule = new StraightRule();

            var hand = new Hand(new List<Card>
            {
                new Card {Suit = Suit.Hearts, Value = 5},
                new Card {Suit = Suit.Spades, Value = 7},
                new Card {Suit = Suit.Diamonds, Value = 6},
                new Card {Suit = Suit.Hearts, Value = 9},
                new Card {Suit = Suit.Clubs, Value = 8}
            });
            
            var actual = rule.ValidateRule(hand);
            Assert.AreEqual(true, actual);
        }
        
        [TestMethod]
        public void If_Straight_Rule_Not_Fulfilled_Then_False_Is_Returned()
        {
            var rule = new StraightRule();

            var hand = new Hand(new List<Card>
            {
                new Card {Suit = Suit.Hearts, Value = 5},
                new Card {Suit = Suit.Spades, Value = 7},
                new Card {Suit = Suit.Hearts, Value = 10},
                new Card {Suit = Suit.Diamonds, Value = 11},
                new Card {Suit = Suit.Clubs, Value = 13}
            });
            
            var actual = rule.ValidateRule(hand);
            Assert.AreEqual(false, actual);
        }
    }
}