namespace Academy.Tests.ModelsTests.CourseTests
{
    using Academy.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Name
    {
        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsNull()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.Name = null);
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooShort()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.Name = "no");
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooLong()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.Name = "noooooooooooooooooooooooooooooooooooooooooooooooo");
        }

        [TestMethod]
        public void ShouldAssignPassedValueAndNotThrowError()
        {
            //Arrange
            var course = new Course("Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act
            course.Name = "New Name";

            //Assert
            Assert.AreEqual("New Name", course.Name);
        }
    }
}