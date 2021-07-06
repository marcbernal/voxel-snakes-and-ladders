using System;
using snakes_and_ladders_lib.Interfaces;

namespace snakes_and_ladders_lib
{
    public class Game
    {
        private readonly IDice _dice;
        public int CurrentPosition { get; private set; }
        public bool IsFinished { get; private set; }

        public Game(IDice dice, int initialPosition = 1)
        {            
            _dice = dice;
            CurrentPosition = initialPosition;
            IsFinished = false;
        }

        public Game(int initialPosition = 1) : this(new DefaultDice(), initialPosition) {
        }

        public void Move(int numberOfSpaces)
        {
            var futurePosition = CurrentPosition + numberOfSpaces;

            if (futurePosition == 100) {
                IsFinished = true;
                CurrentPosition = futurePosition;
            } else if (futurePosition < 100) {
                CurrentPosition = futurePosition;
            }
        }

        public void RollDice() {
            Move(_dice.Roll());
        }
    }
}