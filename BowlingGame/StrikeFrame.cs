namespace BowlingGame
{
    public class StrikeFrame
    {
        public Score Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(2);
    }
}