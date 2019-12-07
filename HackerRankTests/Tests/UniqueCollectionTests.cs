using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests.Tests
{
    public class UniqueCollectionTests: TestBase
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 7, 9 })]
        public void Merge_ShouldReturnUniqueSequence(IEnumerable<int> a, IEnumerable<int> b, IEnumerable<int> expected)
        {
            //Arrange

            //Act
            IEnumerable<int> actual = UniqueCollection.Merge(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(new int[] { -3, -1, 3, 7, 1, -3, 7 }, 3)]
        public void LengthOfPositive_ShouldReturnFirstContinuesPositiveValuesCount(IEnumerable<int> a, int expected)
        {
            //Arrange

            //Act
            int actual = UniqueCollection.LengthOfPositive(a);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
