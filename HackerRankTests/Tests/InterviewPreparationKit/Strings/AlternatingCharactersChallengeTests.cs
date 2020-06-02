using HackerRankProblems.Implementations.InterviewPreparationKit.Strings;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests.InterviewPreparationKit.Strings
{
    public class AlternatingCharactersChallengeTests: TestBase
    {
        [Test]
        [TestCase("AAAA", 3)]
        [TestCase("BBBBB", 4)]
        [TestCase("ABABABAB", 0)]
        [TestCase("BABABA", 0)]
        [TestCase("AAABBB", 4)]
        public void AlternatingCharacters_ShouldReturnMinmumDeletions(string chars, int expectedRes) 
        {
            //Arrange

            //Act
            int actualResult = AlternatingCharactersChallenge.AlternatingCharacters(chars);

            //Assert
            Assert.AreEqual(expectedRes, actualResult);
        }

    }
}
