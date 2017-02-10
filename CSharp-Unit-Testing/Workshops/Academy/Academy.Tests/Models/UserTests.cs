using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Academy.Tests.Models.Fakes
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserShouldAssignNamePropery()
        {
            //Arrange
            string name = "name";
            var sut = new FakeUser(name);

            //Act

            //Assert
            Assert.AreEqual(name, sut.Username);
        }

        [TestMethod]
        public void UserShouldThrowExpectionWhenNullIsPassed()
        {
            //Arrange
            var sut = new FakeUser(null);

            //Act

            //Assert
            Assert.ThrowsException<ArgumentException>(() => sut.Username = null);
        }
    }
}
