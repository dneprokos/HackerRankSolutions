using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class GradingStudentsTests: TestBase
    {
        [Test]
        [TestCase(new int[] { 73, 67, 38, 33, 36 }, new int[] { 75, 67, 40, 33, 36 })]
        public void GradingStudentsShouldReturnActualGrades(int[] inputGrades, int[] expectedOutputGrades)
        {
            //Arrange

            //Act
            int[] actualGrades = GradingStudents.Start(inputGrades);

            //Assert
            Assert.AreEqual(expectedOutputGrades, actualGrades);
        }
    }
}
