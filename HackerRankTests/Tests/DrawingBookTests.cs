using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class DrawingBookTests:TestBase
    {
        [Test]
        [TestCase(6, 2, 1)]
        [TestCase(6, 1, 0)]
        [TestCase(6, 3, 1)]
        [TestCase(7, 2, 1)]
        [TestCase(6, 4, 1)]
        [TestCase(7, 4, 1)]
        [TestCase(7, 7, 0)]
        [TestCase(6, 6, 0)]
        [TestCase(8, 6, 1)]
        [TestCase(8, 5, 2)]
        [TestCase(6, 5, 1)]
        public void PageCount_ShouldReturnMinimumNumberOfPagesToOpen(int n, int p, int expectedResult)
        {
            //Arrange

            //Act
            int result = DrawingBook.PageCount(n, p);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
