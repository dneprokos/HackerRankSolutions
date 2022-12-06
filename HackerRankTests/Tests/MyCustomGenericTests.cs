using HackerRankTests.Infrostructure;
using NUnit.Framework;
using System;
using HackerRankProblems.Implementations;

namespace HackerRankTests.Tests
{
    public class MyCustomGenericTests:TestBase
    {
        //TODO: Split on different tests
        [Test]
        public void MyCustomGeneric_AllMethodsShouldWorkAsExpected()
        {
            //Arrange
            var maxCount = 2;
            var object1 = new MyCustomGeneric<string>("Test", maxCount);

            //Act
            object1.Add("Test2");
            var object2 = object1.CloneObject();

            //Assert
            Assert.AreEqual(maxCount, object1.CurrentCount);
            Assert.AreEqual(maxCount, object1.MaxObjectsCount);
            Assert.AreEqual("Test2", object1.GetData(1));
            Assert.AreEqual(typeof(string), object1.GetDataType());
            Assert.AreEqual(object1.GetData(1), object2.GetData(1));
        }

        [Test]
        public void MyCustomGeneric_ShouldThrowsExceptionIfArrayOverLimit()
        {
            //Arrange
            const int maxCount = 1;
            var myCustomGeneric = new MyCustomGeneric<string>("Test", maxCount);
            var expectedException =
                $"You cannot add more than maximum number {myCustomGeneric.MaxObjectsCount} of elements".ToString();
            try
            {
                //Act
                myCustomGeneric.Add("Test2");
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual(expectedException, ex.Message);
            }
        }
    }
}
