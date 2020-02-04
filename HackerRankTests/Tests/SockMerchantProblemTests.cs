using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class SockMerchantProblemTests: TestBase
    {
        [Test]
        [TestCase(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        [TestCase(new int[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
        public void SockMerchantTest(int [] array, int expectedRes)
        {
            int actualRes = SockMerchantProblem.SockMerchant(array.Length, array);

            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}
