namespace Academy.Tests.CommandsTests.AddingTests.AddStudentToCourseCommandTests
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
        public void ShouldThrowArgumentExceptionWhenPassedCourseIsInvalid()
        {
            //Arrange
            var engineMock = Mock.Create<IEngine>();
            var factoryMock = Mock.Create<IAcademyFactory>();
            var studentMock = Mock.Create<IStudent>();
            var seasonMock = Mock.Create<ISeason>();
            var courseMock = Mock.Create<ICourse>();

            Mock.Arrange(() => studentMock.Username).Returns("Pesho");
            Mock.Arrange(() => seasonMock.Students).Returns(new List<IStudent>() { new Student("Pesho", Track.Dev) });
            Mock.Arrange(() => seasonMock.Courses).Returns(new List<ICourse>() { courseMock });
            Mock.Arrange(() => engineMock.Students).Returns(new List<IStudent>() { studentMock });
            Mock.Arrange(() => engineMock.Seasons).Returns(new List<ISeason>() { seasonMock });

            var command = new AddStudentToCourseCommand(factoryMock, engineMock);

            Assert.ThrowsException<ArgumentException>(() => command.Execute(new List<string>() { "Pesho", "0", "0", "invalid" }));
        }

        //[TestMethod]
        //public void Should
    }
}
