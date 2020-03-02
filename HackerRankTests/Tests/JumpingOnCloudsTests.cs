using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class JumpingOnCloudsTests: TestBase
    {
        [Test]
        [TestCase(new int [] { 0, 1, 0, 0, 0, 1, 0 }, 3)]
        [TestCase(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
        [TestCase(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
        [TestCase(new int[] { 0, 0, 0, 1, 0, 0 }, 3)]
        public void JumpingOnCloudsTest(int [] clouds, int expectedResult)
        {
            //Arrange

            //Act
            int actual = JumpingOnTheClouds.JumpingOnClouds(clouds);

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
