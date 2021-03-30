using System;

namespace BowlingGame
{
    public class Roll
    {
        public Roll(in int value)
        {
            Value = value;
        }

        public int Value { get; }

        public bool IsStrike()
        {
            return Value == 10;
        }
    }
}