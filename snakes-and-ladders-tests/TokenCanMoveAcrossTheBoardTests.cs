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

        [Fact]
        public void TokenStartsAtPosition1() {
            Assert.True(_game.CurrentPosition == 1, "The token doesn't start at position 1.");         
        }
    }
}