using Academy.Models;
using Academy.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Academy.Tests.ModelsTests.SeasonTests
{
    using Telerik.JustMock;

    [TestClass]
    public class ListCourses
    {
        [TestMethod]
        public void ShouldIterateOverCoursesCollectionWhenCollectionIsNotEmpty()
        {
            //Arrange
            var season = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var courseMock = Mock.Create<Course>();

            Mock.Arrange(() => courseMock.ToString());
            season.Courses.Add(courseMock);

            //Act
            season.ListCourses();

            //Assert
            Mock.Assert(() => courseMock.ToString(), Occurs.Once());
        }

        [TestMethod]
        public void ShouldReturnSpecificMessageifThereAreNoUsers()
        {
            //Arrange
            var season = new Season(2016, 2017, Initiative.SoftwareAcademy);

            //Act
            var result = season.ListCourses();

            //Assert
            StringAssert.Contains(result, "no courses");
        }
    }
}
