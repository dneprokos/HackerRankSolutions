using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests.Tests
{
    public class StrairCaseTests: TestBase
    {
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
