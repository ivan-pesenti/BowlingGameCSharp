using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class InvalidBonus : IBonus
    {
        private readonly int _value;

        public InvalidBonus(in int value)
        {
            _value = value;
        }

        public IScore Add(IScore score)
        {
            return new InvalidScore(score.Add(new Score(_value)));
        }
    }
}
