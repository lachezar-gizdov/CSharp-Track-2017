namespace Academy.Tests.ModelsTests.CourseTests
{
    using Academy.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class LecturesPerWeek
    {

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooSmall()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.LecturesPerWeek = 0);
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooBig()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => course.LecturesPerWeek = 8);
        }

        [TestMethod]
        public void ShouldAssignPassedValueAndNotThrowError()
        {
            //Arrange
            var course = new Course("Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act
            course.LecturesPerWeek = 3;

            //Assert
            Assert.AreEqual(3, course.LecturesPerWeek);
        }
    }
}