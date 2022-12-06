using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class KangarooTests:TestBase
    {
        [Test]
        [TestCase(0, 2, 5, 3, "NO")]
        [TestCase(4524, 8092, 4523, 8076, "NO")]
        [TestCase(0, 3, 4, 2, "YES")]
        [TestCase(4523, 8092, 9419, 8076, "YES")]
        public void CanMeetAtOnePoint_ShouldReturnIfKangasHaveMet(int x1, int v1, int x2, int v2, string expected)
        {
            //Arrange

            //Act
            string actual = Kangaroo.CanMeetAtOnePoint(x1, v1, x2, v2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
