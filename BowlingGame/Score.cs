using System;

namespace BowlingGame
{
    public class Score : IScore
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

        public override string ToString() => Value.ToString();
        public TotalScore Add(TotalScore totalScore) => totalScore.Add(this);

        public IScore Add(Roll secondRoll) => new Score(Value + secondRoll.Value);

        public IScore Add(IScore otherScore) => new ScoreChain(this, otherScore);

        public IScore Add(Bonus bonus) => new Score(Value + bonus.Value);

        public bool IsSpare()
        {
            return Value == 10;
        }
    }
}