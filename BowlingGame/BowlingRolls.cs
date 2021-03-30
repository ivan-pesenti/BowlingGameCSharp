using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGame
{
    public class BowlingRolls
    {
        private readonly Queue<Roll> _rolls;

        public BowlingRolls(Queue<Roll> rolls)
        {
            _rolls = rolls;
        }

        public bool HasRolls()
        {
            return CanRoll();
        }

        public bool CanRoll()
        {
            return _rolls.Count > 0;
        }

        public Roll RollOne()
        {
            return _rolls.Dequeue();
        }

        public Bonus Bonus(int howManyRolls)
        {
            var bonusValue = _rolls
                .Take(howManyRolls)
                .Sum(roll => roll.Value);
            return new Bonus(bonusValue);
        }
    }
}
