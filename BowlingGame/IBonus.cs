using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class Bonus : IBonus
    {
        private readonly int _value;
        public Bonus(int value)
        {
            _value = value;
        }

        public IScore Add(IScore score)
        {
            return new Score(score.Value + _value);
        }
    }

    public interface IBonus
    {
        IScore Add(IScore score);
    }
}
