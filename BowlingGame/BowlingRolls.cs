using System;
using System.Collections;
using System.Collections.Generic;
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

        public bool HasElements()
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

        public Roll Bonus()
        {
            return _rolls.Peek();
        }
    }
}
