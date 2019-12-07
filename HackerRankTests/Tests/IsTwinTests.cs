using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class IsTwinShouldReturnIfTrueOrNot:TestBase
    {
        [Test]
        [TestCase("123", "231", true)]
        [TestCase("123", "234", false)]
        [TestCase("123", "2314", false)]
        [TestCase("abc", "bca", true)]
        [TestCase("abc", "bcс", false)]
        [TestCase("abc", "bcaa", false)]
        [TestCase("ab$", "$ab", true)]
        public void isTwinTest(string value1, string value2, bool expectedResult)
        {
            //Arrange

            //Act
            bool actualResult = IsTwin.isTwinLogic(value1, value2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult,
                "{0} and {1} is twin should be {2}", value1, value2, expectedResult);
        }
    }
}
