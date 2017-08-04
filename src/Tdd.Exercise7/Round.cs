namespace Tdd.Exercise7
{
    public class Round
    {
        public IPlayer Play(IPlayer player1, IPlayer player2)
        {
            var hand1 = player1.RevealHand();
            var hand2 = player2.RevealHand();

            var comparison = hand1.CompareWith(hand2);
            if (comparison == 1)
                return player1;
            if (comparison == -1)
                return player2;
            return null;
        }
    }
}