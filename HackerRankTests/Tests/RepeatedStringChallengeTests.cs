using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class RepeatedStringChallengeTests: TestBase
    {
        [Test]
        [TestCase("aba", 10, 7)]
        [TestCase("abcac", 10, 4)]
        [TestCase("a", 1000000000000, 1000000000000)]
        public void RepeatedStringTest(string word, long capacity, long expectedResult)
        {
            //Arrange

            //Act
            long actualResult = RepeatedStringChallenge.RepeatedString(word, capacity);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
