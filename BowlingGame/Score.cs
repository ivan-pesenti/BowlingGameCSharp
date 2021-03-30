using System;

namespace BowlingGame
{
    public class Score
    {
        public int Value { get; }

        public Score(int value = 0)
        {
            Value = value;
        }

        public Score(Roll roll)
        {
            Value = roll.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public Score Add(Roll secondRoll) => new Score(Value + secondRoll.Value);

        public bool IsSpare()
        {
            return Value == 10;
        }

        public Score Add(Score otherScore)
        {
            return new Score(Value + otherScore.Value);
        }
    }
}