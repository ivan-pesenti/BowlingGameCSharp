﻿namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        private readonly BowlingRolls _bowlingRolls;
        private readonly Roll _firstRoll;

        public StrikeFrame(BowlingRolls bowlingRolls, Roll firstRoll)
        {
            _bowlingRolls = bowlingRolls;
            _firstRoll = firstRoll;
        }

        public Score Score()
        {
            return _bowlingRolls.AssignBonus(new Score(_firstRoll.Value), 2);
        }
    }
}