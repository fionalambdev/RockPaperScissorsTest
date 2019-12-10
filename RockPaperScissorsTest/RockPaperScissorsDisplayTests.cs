using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class RockPaperScissorsDisplayTests
    {   
        // tests to see if the winner result is displayed correctly
        [TestMethod]
        public void WinnerDisplayTest()
        {
            int pScoreTest = 3;
            int cpuScoreTest = 1;

            string expectedResult = "You won the game!";

            string result = RockPaperScissors.Program.WinnerDisplay(pScoreTest, cpuScoreTest);
            Assert.AreEqual(expectedResult, result);


        }
        [TestMethod]
        public void ScoreDisplayTest()
        {
            int pScoreTest = 3;
            int cpuScoreTest = 1;

            string expectedResult = "SCORES: Opponent: 1\r\nYOU: 3";

            string result = RockPaperScissors.Program.ScoreDisplay(pScoreTest, cpuScoreTest);

            Assert.AreEqual(expectedResult, result);



        }
        [TestMethod]
        public void MovesDisplayTest()
        {
            int rCountTest = 3;
            int pCountTest = 1;
            int sCountTest = 2;

            string expectedResult = "Rock was used: 3 times.\r\nPaper was used: 1 times.\r\nScissors was used: 2 times.";


            string result = RockPaperScissors.Program.MovesDisplay(rCountTest, pCountTest, sCountTest);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
