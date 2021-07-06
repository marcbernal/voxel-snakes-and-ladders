using Xunit;
using snakes_and_ladders_lib;

namespace snakes_and_ladders_tests
{
    public class TokenCanMoveAcrossTheBoardTests
    {
        private readonly Game _game;

        public TokenCanMoveAcrossTheBoardTests()
        {
            _game = new Game();
        }

        // UAT1
        [Fact]
        public void TokenStartsAtPosition1() {
            Assert.True(_game.CurrentPosition == 1, "The token doesn't start at position 1.");         
        }

        //UAT2
        [Fact]
        public void TokenMoves3Positions() {
            _game.Move(3);
            Assert.True(_game.CurrentPosition == 4, "The token is not on position 4.");         
        }
    }
}