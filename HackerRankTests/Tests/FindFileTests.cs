using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System.IO;

namespace HackerRankTests.Tests
{
    public class FindFileTests:TestBase
    {
        [Test]
        [TestCase("ExpectedFile.txt", "TestData", @"TestData\TestFolder0\TestFolder2\ExpectedFile.txt")]
        [TestCase("ExpectedFile1.txt", "TestData", "")]
        [TestCase("ExpectedFile.txt", @"TestData\TestFolder0\TestFolder1", "")]
        //[TestCase("ExpectedFile.txt", @"C:\TEMP\Temp0\Temp1", "")]
        public void DoesFileExistByPath(string searchFile, string rootSearchFolder, string expectedResult)
        {
            //Arrange
            expectedResult = expectedResult.Equals(string.Empty) ? null : Path.Combine(TestContext.CurrentContext.TestDirectory, expectedResult);
            var rootDirectory = rootSearchFolder.Contains(":") ? 
                rootSearchFolder : 
                Path.Combine(TestContext.CurrentContext.TestDirectory, rootSearchFolder);

            //Act
            var actualResult = FileHelper.GetFilePath(searchFile, rootDirectory);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
