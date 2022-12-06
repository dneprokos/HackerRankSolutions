using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Linq;
using HackerRankProblems.Implementations;

namespace HackerRankTests.Tests
{
    public class FindNumberTests:TestBase
    {
        [TestCase(new[] { 5, 7, 9 }, 7, "YES")]
        [TestCase(new[] { 5, 8, 9 }, 7, "NO")]
        public void Find_ShouldReturnYesOrNo(int[] arr, int searchCriteria, string expectedRes)
        {
            //Arrange

            //Act
            string result = FindNumber.Find(arr.ToList(), searchCriteria);

            //Assert
            Assert.AreEqual(expectedRes, result);
        }
    }
}
