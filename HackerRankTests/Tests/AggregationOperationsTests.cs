using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests.Tests
{
    public class AggregationOperationsTests:TestBase
    {
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
    }
}
