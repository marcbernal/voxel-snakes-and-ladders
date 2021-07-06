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

        // UAT1
        [Fact]
        public void PlayerWonsTheGameFromPosition97AndRolling3() {
            _game.Move(3);
            Assert.True(_game.IsFinished, "The game is not won");
        }

        //UAT2
        [Fact]
        public void PlayerDoesntWonTheGameFromPosition97AndRolling4() {
            _game.Move(4);
            Assert.False(_game.IsFinished, "The player shouldn't have won the game");
            Assert.True(_game.CurrentPosition == 97, "The player is not at position 97");
        }
    }
}