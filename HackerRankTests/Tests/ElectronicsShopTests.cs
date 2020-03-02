using HackerRankProblems.Implementations;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class ElectronicsShopTests
    {
        [Test]
        [TestCase(new int [] { 40, 50, 60 }, new int [] {5, 8, 12 }, 60, 58)]
        [TestCase(new int[] { 40, 50, 60 }, new int[] { 5, 8, 19 }, 60, 59)]
        [TestCase(new int[] { 4 }, new int[] { 5 }, 5, -1)]
        [TestCase(new int[] { 3, 1}, new int[] { 5, 2, 8 }, 10, 9)]
        public void GetMoneySpentTest(int [] keyboards, int [] drivers, int budget, int expectedResult)
        {
            //Arrange

            //Act
            int actual = ElectronicsShop.GetMoneySpent(keyboards, drivers, budget);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
