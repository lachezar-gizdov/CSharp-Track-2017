namespace Academy.Tests.ModelsTests
{
    using Academy.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void ShouldAssignNamePropertyWhenValidValueIsPassed()
        {
            //Arrange & Act
            string name = "Valid Name";
            var course = new Course(name, 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Assert
            Assert.AreEqual(name, course.Name);
        }

        [TestMethod]
        public void ShouldAssignLecturesPerWeekPropertyWhenValidValueIsPassed()
        {
            //Arrange & Act
            int lectures = 5;
            var course = new Course("Valid Name", lectures, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Assert
            Assert.AreEqual(lectures, course.LecturesPerWeek);
        }

        [TestMethod]
        public void ShouldAssignStartDatePropertyWhenValidValueIsPassed()
        {
            //Arrange & Act
            DateTime startDate = new DateTime(2017, 2, 10);
            var course = new Course("Valid Name", 5, startDate, new DateTime(2017, 3, 10));

            //Assert
            Assert.AreEqual(startDate, course.StartingDate);
        }

        [TestMethod]
        public void ShouldAssignEndDatePropertyWhenValidValueIsPassed()
        {
            //Arrange & Act
            DateTime endDate = new DateTime(2017, 3, 10);
            var course = new Course("Valid Name", 5, new DateTime(2017, 2, 10), endDate);

            //Assert
            Assert.AreEqual(endDate, course.EndingDate);
        }

        [TestMethod]
        public void ShouldInitializeOnlineStudentsCollection()
        {
            //Arrange & Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Assert
            Assert.IsNotNull(course.OnlineStudents);
        }

        [TestMethod]
        public void ShouldInitializeOnsiteStudentsCollection()
        {
            //Arrange & Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Assert
            Assert.IsNotNull(course.OnsiteStudents);
        }

        [TestMethod]
        public void ShouldInitializeLecturesCollection()
        {
            //Arrange & Act
            var course = new Course("Valid Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Assert
            Assert.IsNotNull(course.Lectures);
        }
    }
}