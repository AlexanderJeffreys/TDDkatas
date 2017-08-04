using NUnit.Framework;
using Shouldly;

namespace Tdd.Exercise7.Tests
{
    [TestFixture]
    public class HandShould
    {
        [Test]
        public void Comparing_equal_hands_returns_zero()
        {
            var hand1 = Hand.Paper;
            var hand2 = Hand.Paper;
            var result = hand1.CompareWith(hand2);
            result.ShouldBe(0);
        }

        [TestCase(Hand.Paper, Hand.Rock)]
        [TestCase(Hand.Rock, Hand.Scissors)]
        [TestCase(Hand.Scissors, Hand.Paper)]
        public void Comparing_hands_with_winner_first_returns_one(Hand firstHand, Hand secondHand)
        {
            var hand1 = firstHand;
            var hand2 = secondHand;
            var result = hand1.CompareWith(hand2);
            result.ShouldBe(1);
        }

        [TestCase(Hand.Scissors, Hand.Rock)]
        [TestCase(Hand.Rock, Hand.Paper)]
        [TestCase(Hand.Paper, Hand.Scissors)]
        public void Comparing_hands_with_loser_first_returns_minus_one(Hand firstHand, Hand secondHand)
        {
            var hand1 = firstHand;
            var hand2 = secondHand;
            var result = hand1.CompareWith(hand2);
            result.ShouldBe(-1);
        }
        
    }
}