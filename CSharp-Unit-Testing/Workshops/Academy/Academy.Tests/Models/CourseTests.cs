using Academy.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Telerik.JustMock;

namespace Academy.Tests.Models
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void ShouldAssignNamePropertyCorrectly()
        {
            //Assign & Act
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Assert
            Assert.AreEqual(name, course.Name);
        }

        [TestMethod]
        public void ShouldAssignLecturesPropertyCorrectly()
        {
            //Assign & Act
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Assert
            Assert.AreEqual(lectures, course.LecturesPerWeek);
        }

        [TestMethod]
        public void ShouldAssignStartingDatePropertyCorrectly()
        {
            //Assign & Act
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Assert
            Assert.AreEqual(startDate, course.StartingDate);
        }

        [TestMethod]
        public void ShouldThrowArgumentNullExceptionWhenNullIsPassedToStartDate()
        {
            //Assign
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.StartingDate = null);
        }

        [TestMethod]
        public void ShouldThrowArgumentNullExceptionWhenNullIsPassedToEndDate()
        {
            //Assign
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => course.EndingDate = null);
        }

        [TestMethod]
        public void ShouldAssignEndingDatePropertyCorrectly()
        {
            //Assign
            var name = "Name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.AreEqual(endDate, course.EndingDate);
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionIfZeroIsPassedToLecturesCount()
        {
            //Assign
            string name = "name";
            int lectures = 0;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Course(name, lectures, startDate, endDate));
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionIfNegativeIsPassedToLecturesCount()
        {
            //Assign
            string name = "name";
            int lectures = -1;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Course(name, lectures, startDate, endDate));
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionIfMaximumLengthIxExceeded()
        {
            //Assign
            string name = "name";
            int lectures = 46;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Course(name, lectures, startDate, endDate));
        }

        [TestMethod]
        public void ShouldInitializeOnlineStudentsCollection()
        {
            //Assign
            string name = "name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.IsNotNull(course.OnlineStudents);
        }

        [TestMethod]
        public void ShouldInitializeOnsiteStudentsCollection()
        {
            //Assign
            string name = "name";
            int lectures = 4;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.IsNotNull(course.OnsiteStudents);
        }

        [TestMethod]
        public void ShouldThrowExceptionIfNullIsPassedToName()
        {
            //Assign
            int lectures = 5;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Course(null, lectures, startDate, endDate));
        }

        [TestMethod]
        public void ShouldReturnMessageIfThereAreNoLecturesInCourse()
        {
            //Assign
            string name = "name";
            int lectures = 1;
            var startDate = new DateTime(2017, 2, 7);
            var endDate = new DateTime(2017, 2, 9);
            var course = new Course(name, lectures, startDate, endDate);

            //Act & Assert
            Assert.IsTrue(course.ToString().Contains("no lectures"));
        }
    }
}
