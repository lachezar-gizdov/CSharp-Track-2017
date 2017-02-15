namespace IntergalacticTravel.Tests.TeleportStationTests
{
    using IntergalacticTravel.Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var map = new List<IPath>();
            var sut = new TeleportStation(ownerMock, map, locationMock);

            //Act & Assert
            Assert.IsNotNull(sut.)
        }
    }
}

//this.owner = owner;
//this.galacticMap = galacticMap;
//this.location = location;