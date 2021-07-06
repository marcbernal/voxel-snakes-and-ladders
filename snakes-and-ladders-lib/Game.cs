using System;

namespace snakes_and_ladders_lib
{
    public class Game
    {
        public int CurrentPosition { get; private set; }
        public bool IsFinished { get; private set; }

        public Game(int initialPosition = 1)
        {
            CurrentPosition = initialPosition;
            IsFinished = false;
        }

        public void Move(int numberOfSpaces)
        {
            CurrentPosition += numberOfSpaces;
            if (CurrentPosition == 100) IsFinished = true;
        }
    }
}