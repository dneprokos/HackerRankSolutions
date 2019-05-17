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

        [Test]
        [TestCase(new int[4] {4, 4, 1, 3 }, 2)]
        public void BirthdayCakeCandlesTest(int [] candles, int expectedCount)
        {
            //Arrange

            //Act
            int tallestCount = BirthdayCakeCandles.getTallestCandles(candles);

            //Assert
            Assert.AreEqual(expectedCount, tallestCount);
        }

        [Test]
        [TestCase("07:05:45AM", "07:05:45")]
        [TestCase("07:05:45PM", "19:05:45")]
        [TestCase("12:40:22AM", "00:40:22")]
        [TestCase("12:40:22PM", "12:40:22")]
        public void TimeConversionTest(string inputTime, string expectedFormat)
        {
            //Arrange

            //Act
            string outputTime = TimeConversion.ConvertToMillitaryFormat(inputTime);

            //Assert
            Assert.AreEqual(expectedFormat, outputTime);
        }

        [Test]
        [TestCase(new int[] { 73, 67, 38, 33, 36 }, new int[] { 75, 67, 40, 33, 36 })]
        public void GradingStudentsTest(int [] inputGrades, int [] expectedOutputGrades)
        {
            //Arrange

            //Act
            int [] actualGrades = GradingStudents.Start(inputGrades);

            //Assert
            Assert.AreEqual(expectedOutputGrades, actualGrades);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 7, 9 })]
        public void MergeFunction_ShouldReturnUniqueSequence(IEnumerable<int> a, IEnumerable<int> b, IEnumerable<int> expected)
        {
            //Arrange

            //Act
            IEnumerable<int> actual = UniqueCollection.Merge(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new int[] { -3, -1, 3, 7, 1, -3, 7}, 3)]
        public void LengthOfPositive_ShouldReturnFirstContinuesPositiveValuesCount(IEnumerable<int> a, int expected)
        {
            //Arrange

            //Act
            int actual = UniqueCollection.LengthOfPositive(a);

            //Assert
            Assert.AreEqual(expected, actual);      
        }

        [Test]
        [TestCase(2, new int[] { 3, 4, 5 }, 25)]
        [TestCase(3, new int[] { 3, 4, 5 }, 44)]
        [TestCase(3, new int[] { 3, 4, 5, 6 }, 138)]
        public void Poly_ShouldCalculateValueOfNthDeegreePolynomial(int polynomial, IEnumerable<int> polynomialCoefficients, int expected)
        {
            //Arrange

            //Act
            int actual = AggregationOperations.Poly(polynomial, polynomialCoefficients);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void DoesFileExistByPath()
        {
            //TODO: Implement logic where you should check if fileName exists by path,
            //You will have two parameters: filename and some directory
            //File can be placed in any folder under directory
            //You should return path to the file or null if it was not found.
            //Cover it by unit tests

            //Arrange

            //Act

            //Assert
            Assert.IsTrue(false);
        }


    }
}
