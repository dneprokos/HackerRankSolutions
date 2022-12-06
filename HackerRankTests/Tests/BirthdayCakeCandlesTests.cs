using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class BirthdayCakeCandlesTests:TestBase
    {
        [Test]
        [TestCase(new[] { 4, 4, 1, 3 }, 2)]
        public void BirthdayCakeCandlesTest(int[] candles, int expectedCount)
        {
            //Arrange

            //Act
            int tallestCount = BirthdayCakeCandles.getTallestCandles(candles);

            //Assert
            Assert.AreEqual(expectedCount, tallestCount);
        }
    }
}
