using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Bonus
    {
        public int Value { get; }
        public Bonus(in int value)
        {
            Value = value;
        }

    }
}
