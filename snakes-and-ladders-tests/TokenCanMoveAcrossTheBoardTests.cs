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
            Assert.True(_game.CurrentPosition == 4, "The token is not at position 4.");         
        }

        //UAT3
        [Fact]
        public void TokenMovesTwoTimesToPosition8() {
            _game.Move(3);
            _game.Move(4);
            Assert.True(_game.CurrentPosition == 8, "The token is not at position 8.");
        }
    }
}