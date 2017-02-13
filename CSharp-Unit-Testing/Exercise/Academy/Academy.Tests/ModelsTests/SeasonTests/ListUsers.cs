namespace Academy.Tests.ModelsTests.SeasonTests
{
    using Academy.Models;
    using Academy.Models.Enums;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Telerik.JustMock;

    [TestClass]
    public class ListUsers
    {
        [TestMethod]
        public void ShouldIterateOverStudentsCollectionWhenCollectionIsNotEmpty()
        {
            //Arrange
            var season = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var studentMock = Mock.Create<Student>();

            Mock.Arrange(() => studentMock.ToString());
            season.Students.Add(studentMock);

            //Act
            season.ListUsers();

            //Assert
            Mock.Assert(() => studentMock.ToString(), Occurs.Once());
        }

        [TestMethod]
        public void ShouldIterateOverTrainersCollectionWhenCollectionIsNotEmpty()
        {
            //Arrange
            var season = new Season(2016, 2017, Initiative.SoftwareAcademy);
            var trainerMock = Mock.Create<Student>();

            Mock.Arrange(() => trainerMock.ToString());
            season.Students.Add(trainerMock);

            //Act
            season.ListUsers();

            //Assert
            Mock.Assert(() => trainerMock.ToString(), Occurs.Once());
        }

        [TestMethod]
        public void ShouldReturnSpecificMessageifThereAreNoUsers()
        {
            //Arrange
            var season = new Season(2016, 2017, Initiative.SoftwareAcademy);

            //Act
            var result = season.ListUsers();

            //Assert
            StringAssert.Contains(result, "no users");
        }
    }
}
