using System;
using System.IO;
using Xunit;

namespace BowlingGame.Tests
{
    public class BowlingGameTests
    {
        // TODO: Show the total score on the last line. Update the total score while running. When a frame is incomplete it sums its current value.
        // TODO: Show the score by frame on the first line. Update the score only when the frame is closed. Otherwise show a "-".

        // spare
        // all spare
        // strike
        // all strikes
        // last frame

        // One zero
        // all zeros
        // One zero frame
        // Open frame
        // all open frame
        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("1,1", "2")]
        [InlineData("5,5", "10")]
        [InlineData("5,5,1", "12")]
        [InlineData("6,4,1", "12")]
        [InlineData("10", "10")]
        [InlineData("10,1", "12")]
        [InlineData("10,1,1", "14")]
        [InlineData("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0", "0")]
        [InlineData("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", "20")]
        [InlineData("5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5", "150")]
        [InlineData("4,6,4,6,4,6,4,6,4,6,4,6,4,6,4,6,4,6,4,6,4", "140")]
        [InlineData("10,10,10,10,10,10,10,10,10,10,10,10", "300")]
        [InlineData("10,9,1,5,5,7,2,10,10,10,9,0,8,2,9,1,10", "187")]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsTheTotalScoreOnTheSecondLine(string inputRollsStr, string expectedTotalScore)
        {
            var outLines = RunMainProgram(inputRollsStr);
            Assert.Equal(expectedTotalScore, outLines[1]);
        }

        [Theory]
        [InlineData("0", "-")]
        [InlineData("1", "-")]
        [InlineData("1,1", "2")]
        [InlineData("5,5", "-")]
        [InlineData("5,5,1", "12,-")]
        [InlineData("10", "-")]
        [InlineData("10,1", "-,-")]
        [InlineData("10,1,1", "12,2")]
        [InlineData("10,1,1,2,8", "12,2,-")]
        [InlineData("0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0", "0,0,0,0,0,0,0,0,0,0")]
        [InlineData("1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", "2,2,2,2,2,2,2,2,2,2")]
        [InlineData("5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5", "15,15,15,15,15,15,15,15,15,15")]
        public void GIVEN_AnInputFromTheCommandLine_WHEN_ItIsAListOfRolls_THEN_ItPrintsThePartialFrameScoresOnTheFirstLine(string inputRollsStr, string expectedTotalScore)
        {
            var outLines = RunMainProgram(inputRollsStr);
            Assert.Equal(expectedTotalScore, outLines[0]);
        }

        private static string[] ReadInputRolls(string inputRollsStr)
        {
            string[] inputRolls = inputRollsStr.Split(",");
            return inputRolls;
        }

        private static string[] ComputeOutLines(StringWriter myOut)
        {
            var outLines = myOut.ToString().Split(Environment.NewLine);
            return outLines;
        }

        private static string[] RunMainProgram(string inputRollsStr) 
        {
            var myOut = SetStandardOut();
            var inputRolls = ReadInputRolls(inputRollsStr);

            MyProgram.Main(inputRolls);

            var outLines = ComputeOutLines(myOut);
            return outLines;
        }

        private static StringWriter SetStandardOut()
        {
            var myOut = new StringWriter();
            Console.SetOut(myOut);
            return myOut;
        }
    }
}
