using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class ScoreChain : IScore
    {
        private readonly IScore _previousScore;
        private readonly IScore _currentSCore;

        public ScoreChain(IScore previousScore, IScore currentSCore)
        {
            _previousScore = previousScore;
            _currentSCore = currentSCore;
        }

        public TotalScore Add(TotalScore totalScore) => totalScore.Add(this);

        public IScore Add(Roll secondRoll) => new ScoreChain(this, _currentSCore.Add(secondRoll));

        public IScore Add(IScore otherScore) => new ScoreChain(this, otherScore);

        public IScore Add(Bonus bonus) => new ScoreChain(this, _currentSCore.Add(bonus));

        public bool IsSpare() => _currentSCore.IsSpare();

        public int Value => _previousScore.Value + _currentSCore.Value;

        public override string ToString()
        {
            return $"{_previousScore},{_currentSCore}";
        }
    }
}
