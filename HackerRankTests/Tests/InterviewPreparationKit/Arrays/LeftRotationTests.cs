using HackerRankProblems.Implementations.InterviewPreparationKit.Arrays;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests.InterviewPreparationKit.Arrays
{
    public class LeftRotationTests : TestBase
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 2, 3, 4, 5, 1 })]
        [TestCase(new int [] { 1, 2, 3, 4, 5}, 4, new int[] { 5, 1, 2, 3, 4 })]
        public void AddHelloToYourName_ShouldAddHelloBeforeYourName(int [] initArr, int rotCount, int [] expectedRes)
        {
            //Arrange

            //Act
            int [] actRes = LeftRotation.RotLeft(initArr, rotCount);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }
    }
}
