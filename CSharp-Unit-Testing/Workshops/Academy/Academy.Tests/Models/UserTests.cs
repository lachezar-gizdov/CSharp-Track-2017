using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Academy.Tests.Models.Mocks
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void UserShouldAssignNamePropery()
        {
            //Arrange
            string name = "name";
            var sut = new UserMock(name);

            //Act

            //Assert
            Assert.AreEqual(name, sut.Username);
        }

        //[TestMethod]
        //public void UserShouldThrowExpectionWhenNullIsPassed()
        //{
        //    //Arrange
        //    var sut = new FakeUser(null);

        //    //Act

        //    //Assert
        //    Assert.ThrowsException<ArgumentException>(() => sut.Username = null);
        //}
    }
}
