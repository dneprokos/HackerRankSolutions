using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Linq;

namespace HackerRankTests.Tests
{
    public class MigratoryTests:TestBase
    {
        [Test]
        [TestCase(new[] { 1, 4, 4, 4, 5, 3 }, 4)]
        [TestCase(new[] { 1, 1, 1, 2, 3, 3, 3 }, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new[] { 1, 2, 3, 4 }, 1)]
        public void MigratingBirdsTest(int[] birds, int expectedRes)
        {
            //Arrange

            //Act
            int result = Migratory.MigratoryBirds(birds.ToList());

            //Assert
            Assert.AreEqual(expectedRes, result);
        }
    }
}
