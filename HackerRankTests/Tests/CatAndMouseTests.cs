using FluentAssertions;
using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    
    public class CatAndMouseTests : TestBase
    {
        [TestCase(1, 2, 3, "Cat B")]
        [TestCase(1, 3, 2, "Mouse C")]
        public void CatAndMouse_WhoWillWin(int x, int y, int z, string expectedResult)
        {
            //Arrange

            //Act
            string actualResult = CatAndMouse.CatAndMouseResult(x, y, z);

            //Assert
            actualResult.Should().Be(expectedResult);
        }
    }
}
