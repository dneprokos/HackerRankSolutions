using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;
using System.Globalization;

namespace HackerRankTests.Tests
{
    public class PlayWithStringTests: TestBase
    {
        [Test]
        public void Clone_ShouldCloneNewInstance()
        {
            var initialString = "test";
            var clonedString = initialString.Clone();

            Assert.AreEqual(initialString, clonedString);
            Assert.IsTrue(ReferenceEquals(initialString, clonedString));
        }

        [Test]
        [TestCase("test", "test", 0)]
        [TestCase("Test", "test", 1)]
        [TestCase("Test", "Test1", -1)]
        [TestCase("Test1", "Test", 1)]
        public void CompareTo_ShouldReturnWhichSisHigherOrEqual(string first, string second, int expectedResult)
        {
            //Arrange

            //Act
            int actualResult = first.CompareTo(second);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("Hello World!", "Hello", true)]
        [TestCase("Hello World!", "Hell0", false)]
        [TestCase("Hello World!", "Hello W", true)]
        [TestCase("Hello World!", "hello", false)]
        [TestCase("Hello World!1@", "ld!1@", true)]
        public void Contains_ShouldTellIfStringContainsPartOfString(string originWord, string partialWord, bool expectedRes)
        {
            //Arrange

            //Act
            bool actualRes = originWord.Contains(partialWord);

            //Assert
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Test]
        [TestCase("Hello ello", "Hell", true)]
        [TestCase("Pello ello", "Hell", false)]
        [TestCase("hello ello", "Hell", false)]
        public void StartsWith_ShouldTellIfStringStartsWithExpectedValueOrNot(string originWord, string start, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = originWord.StartsWith(start);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("hello Hello", "Hell", true, true)]
        [TestCase("Hello Hello", "Hell", true, true)]
        [TestCase("hello Hello", "Hell", false, false)]
        [TestCase("Hello Hello", "Hell", false, true)]
        public void StartsWith_WithIgnoreCase_ShouldTellIfStringStartsWithExpectedValueOrNot(string originWord, string start, bool ignoreCase, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = originWord.StartsWith(start, ignoreCase, CultureInfo.InvariantCulture);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [TestCase("ello Hello", "ello", true)]
        [TestCase("ello Pello", "Hell", false)]
        [TestCase("ello hello", "Hell", false)]
        public void EndsWith_ShouldTellIfStringEndsWithExpectedValueOrNot(string originWord, string ends, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = originWord.EndsWith(ends);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Hello hello", "Ello", true, true)]
        [TestCase("Hello Hello", "ello", true, true)]
        [TestCase("Hello hello", "Ello", false, false)]
        [TestCase("Hello Hello", "ello", false, true)]
        public void EndsWith_WithIgnoreCase_ShouldTellIfStringEndsWithExpectedValueOrNot(string originWord, string end, bool ignoreCase, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = originWord.EndsWith(end, ignoreCase, CultureInfo.InvariantCulture);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Test", "Test", true)]
        [TestCase("Test", "Test2", false)]
        [TestCase("test", "Test", false)]
        public void Equals_ShouldTellIfStringEqualsToStringOrNot(string word1, string word2, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = word1.Equals(word2);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Test", "test", StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase("Test", "test", StringComparison.Ordinal, false)]
        public void Equals_ComparisonType_ShouldTellIfStringEqualsToStringOrNot(string word1, string word2, StringComparison comparison, bool expectedRes)
        {
            //Arrange

            //Act
            bool actRes = word1.Equals(word2, comparison);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "ho", 3)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "Ho", 0)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "z", -1)]
        public void IndexOf_String_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, string searchable, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "Ho", 1, 6)]
        public void IndexOf_StringWithStartIndex_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, string searchable, int startIndex, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable, startIndex);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "ho", 1, 1, -1)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "ho", 1, 2, -1)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "ho", 1, 4, 3)]
        public void IndexOf_StringWithStartIndexAndCount_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, string searchable, int startIndex, int count, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable, startIndex, count);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "h", 3)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "H", 0)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "z", -1)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "!", 22)]
        public void IndexOf_Char_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, char searchable, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable);

            

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", "H", 1, 6)]
        public void IndexOf_CharWithStartIndex_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, char searchable, int startIndex, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable, startIndex);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho Ho Merry Xmas!", 'h', 1, 1, -1)]
        [TestCase("Ho ho Ho Ho Merry Xmas!", 'h', 1, 3, 3)]
        public void IndexOf_CharWithStartIndexAndCount_ReturnsIndexOfFirstOccurrenceOfSpecifiedCharacter(string originWord, char searchable, int startIndex, int count, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.IndexOf(searchable, startIndex, count);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Ho ho Ho ho Merry Xmas!", "ha", -1)]
        [TestCase("Ho ho Ho ho Merry Xmas!", "ho", 9)]
        public void LastIndexOf_ReturnsIndexOfLastOccurrenceOfSpecifiedCharacter(string originWord, string searchable, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = originWord.LastIndexOf(searchable);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("CAP", "cap")]
        public void ToLower_ConvertsStringToLowerCase(string originWord, string expectedRes)
        {
            //Arrange

            //Act
            string actRes = originWord.ToLower();

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("cap", "CAP")]
        public void ToUpper_ConvertsStringToUpperCase(string originWord, string expectedRes)
        {
            //Arrange

            //Act
            string actRes = originWord.ToUpper();

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Welcome to ", "Paradise", 11, "Welcome to Paradise")]
        [TestCase("to Paradise", "Welcome ", 0, "Welcome to Paradise")]
        [TestCase("Welcome Paradise", " to", 7, "Welcome to Paradise")]
        public void Insert_ShouldAddStringToSpecifiedPosition(string originWord, string value, int startIndex, string expectedRes)
        {
            //Arrange

            //Act
            string actRes = originWord.Insert(startIndex, value);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("TRAP", 4)]
        [TestCase(" TRAP ", 6)]
        public void Length_ReturnsLengthOfString(string word, int expectedRes)
        {
            //Arrange

            //Act
            int actRes = word.Length;

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Hello Mr", 4, 4, "Hell")]
        [TestCase("Hello Mr", 0, 8, "")]
        public void Remove_DeletesCharactersFromBeginningToSpecifiedIndexPosition(string word, int start, int count, string expectedRes)
        {
            //Arrange

            //Act
            string actRes = word.Remove(start, count);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }

        [Test]
        [TestCase("Hello", "lo", " yea", "Hel yea")]
        [TestCase("Hello", "lo", "p", "Help")]
        [TestCase("Hello", "Hel", "lo", "lolo")]
        [TestCase("Hello", "hel", "lo", "Hello")]
        public void Replace_ReplacesTheCharacter(string word, string oldValue, string newValue, string expectedRes)
        {
            //Arrange

            //Act
            string actRes = word.Replace(oldValue, newValue);

            //Assert
            Assert.AreEqual(expectedRes, actRes);
        }


        public void Split_SplitsTheStringBasedOnSpecifiedValue(string word, string [] expectedRes)
        {
            //Arrange

            //Act
            String [] actRes = word.Split();

            //Assert
        }

        public void Substring_ReturnsSubstring()
        {
            //Arrange

            //Act

            //Assert
        }

        public void ToCharArray_ConvertsStringToCharArray()
        {
            //Arrange

            //Act

            //Assert
        }

        public void Trim_RemovesExtraSpacesFromBeginningAndEndingOfTheString()
        {
            //Arrange

            //Act

            //Assert
        }

    }
}
