using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;

namespace Academy.Tests.Models
{
    [TestClass]
    public class SeasonTests
    {
        [Ignore]
        [TestMethod]
        public void ListUsersExpectToIterateTrainerCollection()
        {
            // Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var trainerMock = Mock.Create<IStudent>();


            sut.Students.Add(trainerMock);
            Mock.Arrange(() => trainerMock.ToString()).DoNothing();

            // Act
            var result = sut.ListUsers();

            // Assert
            Mock.Assert(() => trainerMock.ToString(), Occurs.Once());
        }

        [TestMethod]
        public void ListUsersShouldReturnMessage()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            //Act
            var result = sut.ListUsers();

            //Assert
            Assert.AreEqual(result, "There are no users in this season!");
        }

        [TestMethod]
        public void ListCoursesShouldReturnMessage()
        {
            //Arrange
            var sut = new Season(2016, 2017, Initiative.SoftwareAcademy);

            //Act
            var result = sut.ListCourses();

            //Assert
            Assert.AreEqual(result, "There are no courses in this season!");
        }
    }
}
