using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class DiagonalDifferenceProblemTests: TestBase
    {
        [Test]
        [TestCase(6)]
        public void DiagonalAbsoluteDifferenceShouldBeCalculated(int expectedValue)
        {
            //Arrange
            int[][] arr = new int[4][];

            arr[0] = new int[] { 1, 3, 5, 9 };
            arr[1] = new int[] { 8, 12, 4, 16 };
            arr[2] = new int[] { 7, 2, 6, 18 };
            arr[3] = new int[] { 2, 5, 4, 4 };


            //Act
            int actualValue = DiagonalDifferenceProblem.DiagonalDifference(arr);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
