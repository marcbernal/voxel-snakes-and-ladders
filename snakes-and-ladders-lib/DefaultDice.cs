using System;
using snakes_and_ladders_lib.Interfaces;

namespace snakes_and_ladders_lib
{
    public class DefaultDice : IDice
    {
        public int MininumRange { get; private set; } = 1;
        public int MaximumRange { get; private set; } = 6;
        public DefaultDice() {

        }
        public DefaultDice(int mininumRange, int maximumRange) {
            MininumRange = mininumRange;
            MaximumRange = maximumRange;
        }

        public int Roll() {
            return new Random().Next(MininumRange, MaximumRange + 1);
        }
    }
}
