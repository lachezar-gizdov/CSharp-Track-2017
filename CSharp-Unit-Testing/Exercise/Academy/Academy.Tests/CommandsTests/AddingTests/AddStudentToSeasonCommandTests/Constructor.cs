namespace Academy.Tests.CommandsTests.AddingTests.AddStudentToSeasonCommandTests
{
    using Academy.Commands.Adding;
    using Academy.Core.Contracts;
    using Academy.Models;
    using Academy.Tests.CommandsTests.Mocks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Telerik.JustMock;

    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void ShouldThrowArgumentNullExceptionWhenFactoryIsNull()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new AddStudentToSeasonCommand(null, engineMock));
        }

        [TestMethod]
        public void ShouldThrowArgumentNullExceptionWhenEngineIsNull()
        {
            //Arrange
            var factoryMock = Mock.Create<IAcademyFactory>();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => new AddStudentToSeasonCommand(factoryMock, null));
        }

        [TestMethod]
        public void ShouldCorrectlyAssignEngineWhenAllValuesAreCorrect()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();
            var factoryMock = Mock.Create<IAcademyFactory>();

            //Act
            var command = new AddStudentToSeasonCommandMock(factoryMock, engineMock);

            //Assert
            Assert.AreEqual(engineMock, command.Engine);
        }

        [TestMethod]
        public void ShouldCorrectlyAssignFactoryWhenAllValuesAreCorrect()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();
            var factoryMock = Mock.Create<IAcademyFactory>();

            //Act
            var command = new AddStudentToSeasonCommandMock(factoryMock, engineMock);

            //Assert
            Assert.AreEqual(factoryMock, command.AcademyFactory);
        }
    }
}
