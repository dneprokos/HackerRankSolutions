using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class DivisibleSumPairsClassTests: TestBase
    {
        [Test]
        [TestCase(3, new int[] { 1, 3, 2, 6, 1, 2, }, 5)]
        public void DivisibleSumPairs_ShouldReturnNumberOfDivisiblePairs(int k, int[] array, int expectedres)
        {
            //arrange

            //act
            int result = DivisibleSumPairsClass.DivisibleSumPairs(k, array);

            //assert
            Assert.AreEqual(expectedres, result);
        }
    }
}
