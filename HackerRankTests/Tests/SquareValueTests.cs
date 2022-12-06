using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class SquareValueTests:TestBase
    {
        [Test]
        public void ValueTypeAsReferenceTest()
        {
            //Arrange
            int a = 2;

            //Act
            var b = SquareValue.PerformSquare(a);

            //Assert
            Assert.AreEqual(4, b);
        }
    }
}
