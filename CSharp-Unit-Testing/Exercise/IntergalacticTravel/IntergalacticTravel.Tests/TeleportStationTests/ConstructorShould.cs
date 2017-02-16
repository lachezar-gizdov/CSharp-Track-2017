namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using System.Collections.Generic;
    using Telerik.JustMock;

    [TestClass]
    public class ConstructorShould
    {
        [TestMethod]
        public void AssignOwnerProperlyWhenPassedParametersAreCorrect()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();
            var locationMock = Mock.Create<ILocation>();
            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportationStationFake(ownerMock, mapMock, locationMock);

            //Act & Assert
            Assert.AreSame(ownerMock, sut.Owner);
        }

        [TestMethod]
        public void AssignMapProperlyWhenPassedParametersAreCorrect()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();
            var locationMock = Mock.Create<ILocation>();
            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportationStationFake(ownerMock, mapMock, locationMock);

            //Act & Assert
            Assert.AreSame(mapMock, sut.GalacticMap);
        }

        [TestMethod]
        public void AssignLocationProperlyWhenPassedParametersAreCorrect()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();
            var locationMock = Mock.Create<ILocation>();
            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportationStationFake(ownerMock, mapMock, locationMock);

            //Act & Assert
            Assert.AreSame(locationMock, sut.Location);
        }
    }
}