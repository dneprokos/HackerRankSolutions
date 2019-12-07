using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class BreackingRecordsTests:TestBase
    {
        [Test]
        [TestCase(new int[] { 12, 24, 10, 24 }, new int[] { 1, 1 })]
        [TestCase(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42, }, new int[] { 4, 0 })]
        [TestCase(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, new int[] { 2, 4 })]
        [TestCase(new int[] { 10, 10, 10 }, new int[] { 0, 0 })]
        public void BreakingRecords_ShouldReturnWithBreackingRecords(int[] gameScores, int[] expectedRes)
        {
            //Arrange

            //Act
            int[] result = BreackingRecords.BreakingRecords(gameScores);

            //Assert
            CollectionAssert.AreEqual(expectedRes, result);
        }
    }
}
