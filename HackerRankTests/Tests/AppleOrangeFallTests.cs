using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;
using HackerRankProblems.Implementations;

namespace HackerRankTests.Tests
{
    public class AppleOrangeFallTests: TestBase
    {
        [Test]
        [TestCase(7, 10, 4, 12, new[] { 2, 3, -1 }, new[] { -3, 1, -2 })]
        public void AppleAndOrangeCountTest(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            //Arrange

            //Act
            Tuple<int, int> actual = AppleOrangeFall.CountApplesAndOranges(s, t, a, b, apples, oranges);

            //Assert
            //TODO: Finish assert 
        }
    }
}
