﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public interface IFrame
    {
        IScore Score(BowlingRolls rolls);
    }
}
