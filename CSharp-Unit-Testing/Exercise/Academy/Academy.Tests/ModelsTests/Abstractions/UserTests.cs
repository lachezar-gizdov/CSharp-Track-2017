namespace Academy.Tests.ModelsTests.Abstractions
{
    using Academy.Tests.Fakes;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void ShouldCorrectlyAssignPassedValue()
        {
            //Arange
            var user = new UserFake("Name");

            //Act
            user.Username = "Pesho";

            //Assert
            Assert.AreEqual("Pesho", user.Username);
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsNull()
        {
            //Arange
            var user = new UserFake("Name");

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => user.Username = null);
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooShort()
        {
            //Arrange
            var user = new UserFake("Name");

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => user.Username = "no");
        }

        [TestMethod]
        public void ShouldThrowArgumentExceptionWhenPassedValueIsTooLong()
        {
            //Arrange
            var user = new UserFake("Name");

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => user.Username = "noooooooooooooooo");
        }
    }
}
