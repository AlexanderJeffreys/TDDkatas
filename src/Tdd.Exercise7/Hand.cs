using System;

namespace Tdd.Exercise7
{
    public enum Hand
    {
        Rock,
        Paper,
        Scissors,
    }

    public static class HandExtensions
    {
        public static int CompareWith(this Hand thisHand, Hand otherHand)
        {
            var difference = ((thisHand - otherHand + 3) % 3);
            if (difference == 2) return -1;
            return difference;
        }
    }
}