using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise7
{
    public class Game
    {
        private readonly Round _round;

        public Game()
        {
            _round = new Round();
        }

        public GameResult Play(IPlayer player1, IPlayer player2)
        {
            var wins = new Dictionary<IPlayer, int>
            {
                {player1, 0},
                {player2, 0},
            };

            int roundCount = 0;

            while(!GameEnded(roundCount, wins))
            {
                roundCount++;

                var winner = _round.Play(player1, player2);
                if (winner != null)
                {
                    wins[winner]++;
                }
            }

            IPlayer winningPlayer = PlayerWithHighestScore(wins);

            return new GameResult(roundCount, winningPlayer);
        }

        private bool GameEnded(int roundCount, Dictionary<IPlayer, int> wins)
        {
            return roundCount >= 3 && wins.Values.Distinct().Count() != 1;
        }

        private IPlayer PlayerWithHighestScore(Dictionary<IPlayer, int> wins)
        {
             return wins.OrderByDescending(pair => pair.Value).First().Key;
        }
    }
}