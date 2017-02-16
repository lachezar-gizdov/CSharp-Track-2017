namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using Contracts;
    using Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using System;
    using System.Collections.Generic;
    using Telerik.JustMock;

    [TestClass]
    public class TeleportUnitShould
    {
        [TestMethod]
        public void ThrowArgumentNullExceptionWhenUnitIsNull()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();
            var locationMock = Mock.Create<ILocation>();
            var targetLocationMock = Mock.Create<ILocation>();
            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportStation(ownerMock, mapMock, locationMock);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.TeleportUnit(null, targetLocationMock));
        }

        [TestMethod]
        public void ThrowArgumentNullExceptionWhenLocaltionIsNull()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();
            var locationMock = Mock.Create<ILocation>();
            var unitMock = Mock.Create<IUnit>();
            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportStation(ownerMock, mapMock, locationMock);

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.TeleportUnit(unitMock, null));
        }

        [TestMethod]
        public void ThrowTeleportOutOfRangeExceptionWhenUnitTriesToUseTeleportFromDistantLocation()
        {
            //Arrange
            var ownerMock = Mock.Create<IBusinessOwner>();

            var locationMock = Mock.Create<ILocation>();
            Mock.Arrange(() => locationMock.Planet.Name).Returns("Earth");

            var unitMock = Mock.Create<IUnit>();
            Mock.Arrange(() => unitMock.CurrentLocation.Planet.Name).Returns("Moon");

            var mapMock = Mock.Create<IEnumerable<IPath>>();
            var sut = new TeleportStation(ownerMock, mapMock, locationMock);

            var targetLocationMock = Mock.Create<ILocation>();

            //Act & Assert
            Assert.ThrowsException<TeleportOutOfRangeException>(() => sut.TeleportUnit(unitMock, targetLocationMock));
        }

        [TestMethod]
        public void ThrowInvalidTeleportationLocationExceptionWhenUnitsLocationsOverlap()
        {
            //Arrange
            string planetName = "Earth";
            string galaxyName = "MilkyWay";
            double latitude = 15d;
            double longitude = 15d;
            var ownerMock = Mock.Create<IBusinessOwner>();

            var teleportlocationMock = Mock.Create<ILocation>();
            Mock.Arrange(() => teleportlocationMock.Planet.Name).Returns(planetName);
            Mock.Arrange(() => teleportlocationMock.Planet.Galaxy.Name).Returns(galaxyName);

            var planetUnitMock = Mock.Create<IUnit>();
            Mock.Arrange(() => planetUnitMock.CurrentLocation.Planet.Name).Returns(planetName);
            Mock.Arrange(() => planetUnitMock.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            Mock.Arrange(() => planetUnitMock.CurrentLocation.Coordinates.Latitude).Returns(latitude);
            Mock.Arrange(() => planetUnitMock.CurrentLocation.Coordinates.Longtitude).Returns(longitude);

            var unitToTeleportMock = Mock.Create<IUnit>();
            Mock.Arrange(() => unitToTeleportMock.CurrentLocation.Planet.Name).Returns(planetName);
            Mock.Arrange(() => unitToTeleportMock.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);
            Mock.Arrange(() => unitToTeleportMock.CurrentLocation.Coordinates.Latitude).Returns(latitude);
            Mock.Arrange(() => unitToTeleportMock.CurrentLocation.Coordinates.Longtitude).Returns(longitude);

            var planetUnitsList = new List<IUnit>() { planetUnitMock };

            var pathMock = Mock.Create<IPath>();
            Mock.Arrange(() => pathMock.TargetLocation.Planet.Name).Returns(planetName);
            Mock.Arrange(() => pathMock.TargetLocation.Planet.Galaxy.Name).Returns(galaxyName);
            Mock.Arrange(() => pathMock.Cost.GoldCoins).Returns(10);
            Mock.Arrange(() => pathMock.Cost.SilverCoins).Returns(10);
            Mock.Arrange(() => pathMock.Cost.BronzeCoins).Returns(10);
            Mock.Arrange(() => pathMock.TargetLocation.Planet.Units).Returns(planetUnitsList);

            var map = new List<IPath>() { pathMock };

            var sut = new TeleportationStationFake(ownerMock, map, teleportlocationMock);

            var targetLocationMock = Mock.Create<ILocation>();
            Mock.Arrange(() => targetLocationMock.Coordinates.Latitude).Returns(latitude);
            Mock.Arrange(() => targetLocationMock.Coordinates.Longtitude).Returns(longitude);
            Mock.Arrange(() => targetLocationMock.Planet.Name).Returns(planetName);
            Mock.Arrange(() => targetLocationMock.Planet.Galaxy.Name).Returns(galaxyName);

            //Act & Assert
            Assert.ThrowsException<InvalidTeleportationLocationException>(() => sut.TeleportUnit(unitToTeleportMock, targetLocationMock));
        }

        [TestMethod]
        public void ThrowLocationNotFoundExceptionWhenTargetGalaxyisNotFoundInTeleportStationLocationsList()
        {
            ////Arrange
            //string planetName = "Earth";
            //string galaxyName = "MilkyWay";

            //var ownerMock = Mock.Create<IBusinessOwner>();

            //var teleportlocationMock = Mock.Create<ILocation>();
            //Mock.Arrange(() => teleportlocationMock.Planet.Name).Returns(planetName);
            //Mock.Arrange(() => teleportlocationMock.Planet.Galaxy.Name).Returns(galaxyName);

            //var unitToTeleportMock = Mock.Create<IUnit>();
            //Mock.Arrange(() => planetUnitMock.CurrentLocation.Planet.Name).Returns(planetName);
            //Mock.Arrange(() => planetUnitMock.CurrentLocation.Planet.Galaxy.Name).Returns(galaxyName);


            //var planetUnitsList = new List<IUnit>() { planetUnitMock };

            //var pathMock = Mock.Create<IPath>();
            //Mock.Arrange(() => pathMock.TargetLocation.Planet.Name).Returns(planetName);
            //Mock.Arrange(() => pathMock.TargetLocation.Planet.Galaxy.Name).Returns(galaxyName);
            //Mock.Arrange(() => pathMock.Cost.GoldCoins).Returns(10);
            //Mock.Arrange(() => pathMock.Cost.SilverCoins).Returns(10);
            //Mock.Arrange(() => pathMock.Cost.BronzeCoins).Returns(10);
            //Mock.Arrange(() => pathMock.TargetLocation.Planet.Units).Returns(planetUnitsList);

            //var map = new List<IPath>() { pathMock };

            //var sut = new TeleportationStationFake(ownerMock, map, teleportlocationMock);

            //var targetLocationMock = Mock.Create<ILocation>();
            //Mock.Arrange(() => targetLocationMock.Coordinates.Latitude).Returns(latitude);
            //Mock.Arrange(() => targetLocationMock.Coordinates.Longtitude).Returns(longitude);
            //Mock.Arrange(() => targetLocationMock.Planet.Name).Returns(planetName);
            //Mock.Arrange(() => targetLocationMock.Planet.Galaxy.Name).Returns(galaxyName);
        }
    }
}
