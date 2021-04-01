using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public interface IScore
    {
        IScore Add(Roll secondRoll);
        IScore Add(IScore otherScore);
        IScore Add(IBonus bonus);
        bool IsSpare();
        TotalScore Add(TotalScore totalScore);

        int Value { get; }
    }
}
