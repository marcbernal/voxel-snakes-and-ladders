using Xunit;
using snakes_and_ladders_lib;

namespace snakes_and_ladders_tests
{
    public class PlayerCanWinTheGame
    {
        private readonly Game _game;
        
        public PlayerCanWinTheGame() {
            _game = new Game(97);
        }

        [Fact]
        public void PlayerWonsTheGameFromPosition97AndRolling3() {
            _game.Move(3);
            Assert.True(_game.IsFinished, "The game is not won");
        }
    }
}