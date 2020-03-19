using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class RepeatedStringChalangeTests: TestBase
    {
        [Test]
        [TestCase("aba", 10, 7)]
        [TestCase("a", 1000000000000, 1000000000000)]
        public void RepeatedStringTest(string word, int capacity, int expectedResult)
        {
            //Arrange

            //Act
            long actualResult = RepeatedStringChalange.RepeatedString(word, capacity);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
