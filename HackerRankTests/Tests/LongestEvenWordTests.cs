using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class LongestEvenWordTests:TestBase
    {
        [Test]
        [TestCase("today is a good day", "good")]
        [TestCase("It is a pleasant day today", "pleasant")]
        [TestCase("You can do it the way you like", "like")]
        [TestCase("Time to write great code", "Time")]
        [TestCase("Write code for a great time", "code")]
        public void Find_FindsLongestEvenWordOfSentence(string sentence, string expectedRes)
        {
            //Arrange

            //Act
            string result = LongestEvenWord.Find(sentence);

            //Assert
            Assert.AreEqual(expectedRes, result);
        }
    }
}
