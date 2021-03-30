namespace BowlingGame
{
    public class Score
    {
        public int Value { get; }

        public Score(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}