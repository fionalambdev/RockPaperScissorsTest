using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result;
            string expectedResult;
            int playerScore = 3;
            int cpuScore = 1;
            int rockCount = 2;
            int paperCount = 3;
            int scissorsCount = 3;


            result = RockPaperScissors.Program.ScoreDisplay(3, 1, 2, 3, 3);
        }
    }
}
