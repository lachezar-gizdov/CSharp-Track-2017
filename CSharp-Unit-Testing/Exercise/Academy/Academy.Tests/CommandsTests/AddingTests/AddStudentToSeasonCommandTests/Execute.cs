namespace Academy.Tests.CommandsTests.AddingTests.AddStudentToSeasonCommandTests
{
    using Academy.Commands.Adding;
    using Academy.Core.Contracts;
    using Academy.Models;
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using Telerik.JustMock;

    [TestClass]
    public class Execute
    {
        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedStudentIsAlreadyPartOfTheSeason()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();
            var factoryMock = Mock.Create<IAcademyFactory>();
            var studentMock = Mock.Create<IStudent>();
            var seasonMock = Mock.Create<ISeason>();

            Mock.Arrange(() => studentMock.Username).Returns("Pesho");
            Mock.Arrange(() => engineMock.Students).Returns(new List<IStudent>() { studentMock });
            Mock.Arrange(() => seasonMock.Students).Returns(new List<IStudent>() { new Student("Pesho", Track.Dev) });
            Mock.Arrange(() => engineMock.Seasons).Returns(new List<ISeason>() { seasonMock });

            var command = new AddStudentToSeasonCommand(factoryMock, engineMock);

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => command.Execute(new List<string>() { "Pesho", "0" }));
        }

        [TestMethod]
        public void ShouldCorrectlyAddTheStudentToTheSeason()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();
            var factoryMock = Mock.Create<IAcademyFactory>();
            var studentMock = Mock.Create<IStudent>();
            var seasonMock = Mock.Create<ISeason>();

            Mock.Arrange(() => engineMock.Students).Returns(new List<IStudent>() { studentMock });
            Mock.Arrange(() => seasonMock.Students).Returns(new List<IStudent>() { new Student("Pesho", Track.Dev) });
            Mock.Arrange(() => engineMock.Seasons).Returns(new List<ISeason>() { seasonMock });

            var command = new AddStudentToSeasonCommand(factoryMock, engineMock);

            //Assert
            Assert.AreEqual(1, seasonMock.Students.Count);
        }
    }
}
