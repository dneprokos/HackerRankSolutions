using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.Collections.Generic;

namespace HackerRankTests.Tests
{
    public class IncrementTests: TestBase
    {
        private List<int> arrayExpRes = new List<int> { 0, 1, 2 };
        private List<int> arrayActRes;

        [SetUp]
        public void TestInit()
        {
            arrayActRes = new List<int>();
        }


        [Test]
        public void PreIncrementArrayValidationTest()
        {
            for (int i = 0; i < 3; ++i)
            {
                arrayActRes.Add(i);
            }

            Assert.AreEqual(arrayExpRes, arrayActRes);
        }

        [Test]
        public void PostIncrementArrayValidationTest()
        {
            for (int i = 0; i < 3; i++)
            {
                arrayActRes.Add(i);
            }

            Assert.AreEqual(arrayExpRes, arrayActRes);
        }
    }
}
