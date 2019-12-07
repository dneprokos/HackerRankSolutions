using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class WinnerTests:TestBase
    {
        [Test]
        [TestCase("EMH", "HME", "Tie")]
        [TestCase("EMH", "HEE", "Erica")]
        [TestCase("MMM", "MMH", "Bob")]
        public void Calculate_ReturnWinnerName(string ericaRes, string bobRes, string expectedWinner)
        {
            //Arrange

            //Act
            string result = Winner.Calculate(ericaRes, bobRes);

            //Assert
            Assert.AreEqual(expectedWinner, result);
        }
    }
}
