using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class VersionComparerTests:TestBase
    {
        [Test]
        [TestCase("1.2.3", "1.2.4", -1)]
        [TestCase("1.2.3", "2.1.3", -1)]
        [TestCase("1.2.3", "1.2.3", 0)]
        [TestCase("1.2.3", "1.2.3.4", -1)]
        [TestCase("1.2.3.5", "1.2.3", 1)]
        [TestCase("12.2.3", "1.2.3", 1)]
        public void Compare_ShouldReturnIfVersionsAreIdenticalOrHigherOrLower(string version1, string version2, int expectedResult)
        {
            //Arrange

            //Act
            int actualResult = VersionComparer.Compare(version1, version2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
