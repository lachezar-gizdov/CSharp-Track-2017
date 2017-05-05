namespace SchoolSystemTests.Core
{
    using SchoolSystem.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Telerik.JustMock;
    using SchoolSystem.Contracts;

    [TestClass]
    public class EngineShould
    {
        [TestMethod]
        public void ThrowErrorWhenPassedReaderIsNull()
        {
            // Assign
            var loggerMock = Mock.Create<ILogger>();

            //Act & Assert
            Assert.ThrowsException<NullReferenceException>(() => new Engine(null, loggerMock));
        }

        [TestMethod]
        public void ThrowErrorWhenPassedLoggerIsNull()
        {
            // Assign
            var readerMock = Mock.Create<IReader>();

            //Act & Assert
            Assert.ThrowsException<NullReferenceException>(() => new Engine(readerMock, null));
        }
    }
}
