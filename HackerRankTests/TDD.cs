﻿using HackerRankProblems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

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
        [TestCase(7, 10, 4, 12, new int[] { 2, 3, -1 }, new int[] { -3, 1, -2 })]
        public void AppleAndOrangeCountTest(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //Arrange

            //Act
            Tuple<int, int> actual = AppleOrangeFall.CountApplesAndOranges(s, t, a, b, apples, oranges);

            //Assert
           
        }

        [Test]
        [TestCase(0, 2, 5, 3, "NO")]
        [TestCase(4524, 8092, 4523, 8076, "NO")]
        [TestCase(0, 3, 4, 2, "YES")]
        [TestCase(4523, 8092, 9419, 8076, "YES")]
        public void KangasJumpTest(int x1, int v1, int x2, int v2, string expected)
        {
            //Arrange

            //Act
            string actual = Kangaroo.CanMeetAtOnePoint(x1, v1, x2, v2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        [TestCase("ExpectedFile.txt",  "TestData", @"TestData\TestFolder0\TestFolder2\ExpectedFile.txt")]
        [TestCase("ExpectedFile1.txt", "TestData", "")]
        [TestCase("ExpectedFile.txt", @"TestData\TestFolder0\TestFolder1", "")]
        [TestCase("ExpectedFile.txt", @"C:\TEMP\Temp0\Temp1", "")]
        public void DoesFileExistByPath(string searchFile, string rootSearchFolder, string expectedResult)
        {
            //Arrange
            expectedResult = expectedResult.Equals(string.Empty) ? null : Path.Combine(TestContext.CurrentContext.TestDirectory, expectedResult);
            var rootDirectory = rootSearchFolder.Contains(":") ? rootSearchFolder : Path.Combine(TestContext.CurrentContext.TestDirectory, rootSearchFolder);

            //Act
            var actualResult = FindFile.GetFileByRootDirectory(searchFile, rootDirectory);
            

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
