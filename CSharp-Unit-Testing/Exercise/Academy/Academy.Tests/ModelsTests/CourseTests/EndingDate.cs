﻿namespace Academy.Tests.ModelsTests.CourseTests
{
    using Academy.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class EndingDate
    {
        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsNull()
        {
            //Arrange
            var course = new Course("name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.EndingDate = null);
        }

        [TestMethod]
        public void ShouldAssignPassedValueAndNotThrowError()
        {
            //Arrange
            var course = new Course("Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));
            var newDate = new DateTime(2017, 10, 10);

            //Act
            course.EndingDate = newDate;

            //Assert
            Assert.AreEqual(newDate, course.EndingDate);
        }

    }
}