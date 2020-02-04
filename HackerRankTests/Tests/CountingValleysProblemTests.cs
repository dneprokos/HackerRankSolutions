using HackerRankProblems.Implementations;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class CountingValleysProblemTests
    {
        [Test]
        [TestCase("UDDDUDUU", 1)]
        [TestCase("UD", 0)]
        [TestCase("DU", 1)]
        [TestCase("DD", 1)]
        [TestCase("UU", 0)]
        public void CountingValleysTest(string steps, int expectedRes)
        {
            int actualRes = CountingValleysProblem.CountingValleys(steps.Length, steps);

            Assert.AreEqual(expectedRes, actualRes);
        }
    }
}
