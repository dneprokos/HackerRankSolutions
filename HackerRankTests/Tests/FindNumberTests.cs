using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Linq;

namespace HackerRankTests.Tests
{
    public class FindNumberTests:TestBase
    {
        [Test]
        [TestCase(new int[] { 5, 7, 9 }, 7, "YES")]
        [TestCase(new int[] { 5, 8, 9 }, 7, "NO")]
        public void Find_ShouldReturnYesOrNo(int[] arr, int seachCriteria, string expectedRes)
        {
            //Arrange

            //Act
            string result = FindNumber.Find(arr.ToList(), seachCriteria);

            //Assert
            Assert.AreEqual(expectedRes, result);
        }
    }
}
