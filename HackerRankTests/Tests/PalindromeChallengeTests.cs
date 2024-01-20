using FluentAssertions;
using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    
    public class PalindromeChallengeTests : TestBase
    {
        [TestCase("Mr. Owl ate my metal worm", false, true)]
        [TestCase("Do geese see God?", false, true)]
        [TestCase("Was it a car or a cat I saw?", false, true)]
        [TestCase("Rats live on no evil star", false, true)]
        [TestCase("Live on time, emit no evil", false, true)]
        [TestCase("Step on no pets", false, true)]
        public void IsPalindromeSentence_ShouldVerifyIfTrue(string sentence, bool isCaseSensitive, bool expectedResult)
        {
            //Arrange

            //Act
            bool isPallindrome = PalindromeChallenge.IsPalindromeSentence(sentence, isCaseSensitive);

            //Assert
            isPallindrome.Should().Be(expectedResult);
        }
    }
}
