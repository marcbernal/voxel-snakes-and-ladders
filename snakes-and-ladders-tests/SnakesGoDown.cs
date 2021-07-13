using Xunit;
using snakes_and_ladders_lib;

namespace snakes_and_ladders_tests
{
    public class SnakesGoDown
    {
        private readonly Game _game;

        public SnakesGoDown() {
           _game = new Game();
        }

        // UAT1
        [Fact]
        public void SnakeOn12To2() {
            _game.Move(11);
            Assert.Equal(_game.CurrentPosition, 2);
        }

        // UAT2
        [Fact]
        public void TokenLandsOn2TokenRemainsOn2() {
            _game.Move(1);
            Assert.Equal(_game.CurrentPosition, 2);
        }

        
       
    }
}