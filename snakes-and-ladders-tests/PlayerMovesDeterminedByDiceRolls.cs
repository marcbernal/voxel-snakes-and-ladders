using Xunit;
using snakes_and_ladders_lib;
using Moq;
using snakes_and_ladders_lib.Interfaces;

namespace snakes_and_ladders_tests
{
    public class PlayerMovesDeterminedByDiceRolls
    {
        private Game _game;

        // UAT1
        [Fact]
        public void RollIsBetween1And6() {   
            // We can mock the IDice interface and fake the results for 1 and 6, but I am not sure what value will that test give to us.
            // Also, I don't see a real test over the DefaultDice class since we will need to repeat the test X times to trust it.     
            // For this reason I preferred to add properties to have more control about the min/max values for the dice, but also i neither think
            // it's the best approach because we are not sure if Roll method is using the properties.
            var dice = new DefaultDice();
            Assert.True(dice.MininumRange == 1, "The minimum value for the dice should be 1");
            Assert.True(dice.MaximumRange == 6, "The maximum value for the dice should be 6");
            int minValue = 3;
            int maxValue = 8;
            dice = new DefaultDice(minValue, maxValue);
            Assert.True(dice.MininumRange == minValue, $"The minimum value for the dice should be {minValue}");
            Assert.True(dice.MaximumRange == maxValue, $"The maximum value for the dice should be {maxValue}");            
        }

        // UAT2
        [Fact]
        public void RollIs4ShouldMove4Spaces() {                        
            var diceMock = new Mock<IDice>();
             diceMock.Setup(dice => dice.Roll()).Returns(4);
            _game = new Game(diceMock.Object);
            _game.RollDice();
            Assert.True(_game.CurrentPosition == 5, "The token should move 4 spaces.");
        }
    }
}