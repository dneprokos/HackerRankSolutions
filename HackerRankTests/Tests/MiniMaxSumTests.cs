using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests.Tests
{
    public class MiniMaxSumTests: TestBase
    {
        [Test]
        public void MinMaxSumShouldBeReturned()
        {
            //Arrange
            List<long> expectedValues = new List<long>() { 2063136757, 2744467344 };

            int[] inputValue = new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 };

            //Act
            List<long> actualValues = MiniMaxSum.MiniMaxSumSolution(inputValue);

            //Assert
            Assert.AreEqual(expectedValues, actualValues);
        }
    }
}
