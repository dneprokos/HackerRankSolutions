using HackerRankProblems;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests
{
    [TestFixture]
    public class TDD
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

        [Test]
        public void StrairCasesTest()
        {
            //Arrange
            IList<string> expectedResult = new List<string>()
            {
                "    #",
                "   ##",
                "  ###",
                " ####",
                "#####"
            };

            //Act
            IList<string> actualResult = Staircase.StaircaseSolution(5);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
