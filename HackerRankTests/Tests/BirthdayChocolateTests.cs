using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Linq;

namespace HackerRankTests.Tests
{
    public class BirthdayChocolateTests:TestBase
    {
        [Test]
        [TestCase(new int[] { 1, 2, 1, 3, 2, }, 3, 2, 2)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 3, 2, 0)]
        [TestCase(new int[] { 4 }, 4, 1, 1)]
        [TestCase(new int[] { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }, 18, 7, 3)]
        public void Birthday_ShouldReturnNumberOfChocolatePieces(int[] squares, int day, int month, int expectedRes)
        {
            //Arrange

            //Act
            int result = BirthdayChocolate.Birthday(squares.ToList(), day, month);

            //Assert
            Assert.AreEqual(expectedRes, result);
        }
    }
}
