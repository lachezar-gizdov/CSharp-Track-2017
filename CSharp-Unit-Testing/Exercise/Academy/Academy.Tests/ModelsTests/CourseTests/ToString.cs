namespace Academy.Tests.ModelsTests.CourseTests
{
    using Academy.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Telerik.JustMock;

    [TestClass]
    public class ToString
    {
        [TestMethod]
        public void ShouldIterateOverLecturesCollectionWhenCollectionIsNotEmpty()
        {
            //Arrange
            var course = new Course("Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));
            var lectureMock = Mock.Create<Lecture>();

            Mock.Arrange(() => lectureMock.ToString());
            course.Lectures.Add(lectureMock);

            //Act
            course.ToString();

            //Assert
            Mock.Assert(() => lectureMock.ToString(), Occurs.Once());
        }

        [TestMethod]
        public void ShouldReturnSpecificMessageifThereAreNoLectures()
        {
            //Arrange
            var course = new Course("Name", 5, new DateTime(2017, 2, 10), new DateTime(2017, 3, 10));

            //Act
            var result = course.ToString();

            //Assert
            StringAssert.Contains(result, "no lectures");
        }
    }
}