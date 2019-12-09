using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace RockPaperScissorsTest
{
    [TestClass]
    public class ScoreDisplayTests
    {
        [TestMethod]
        public void DoScoresDisplayCorrectly()
        {
            string result;
            string expectedResult;
            int playerScore = 3;
            int cpuScore = 1;
            int rockCount = 2;
            int paperCount = 3;
            int scissorsCount = 3;
            

            expectedResult = Program.ScoreDisplay(3, 1, 2, 3, 3);


        }
    }
}
