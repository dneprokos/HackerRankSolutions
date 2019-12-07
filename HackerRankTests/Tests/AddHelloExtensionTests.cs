using HackerRankProblems;
using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;

namespace HackerRankTests.Tests
{
    public class AddExtensionTests:TestBase
    {
        [Test]
        [TestCase("Kostas", "Hello Kostas")]
        [TestCase("123", "Hello 123")]
        public void AddHelloToYourName_ShouldAddHelloBeforeYourName(string name, string expectedResult)
        {
            //Arrange

            //Act
            string actual = name.AddHelloToYourName();

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(1, 0.5)]
        [TestCase(0, 0)]
        public void DevideByTwo_ShouldReturnValueDevidedByTwo(Double originalValue, double expectedResult)
        {
            //Arrange

            //Act
            double actual = originalValue.DevideByTwo();

            //Assert
            Assert.AreEqual(expectedResult, actual);
        }

    }
}
