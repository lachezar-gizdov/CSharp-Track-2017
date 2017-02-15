namespace IntergalacticTravel.Tests.UnitsFactoryTests
{
    using IntergalacticTravel.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using IntergalacticTravel;

    [TestClass]
    public class GetUnitShould
    {
        [TestMethod]
        public void ThrowInvalidUnitCreationCommandExceptionWhenUnitTypeIsInvalid()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(() => sut.GetUnit("create unit Invalid Pesho 1"));
        }

        [TestMethod]
        public void ThrowInvalidUnitCreationCommandExceptionWhenUnitIDIsNotANumber()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(() => sut.GetUnit("create unit Lacaille Pesho NotANumber"));
        }

        [TestMethod]
        public void ThrowInvalidUnitCreationCommandExceptionWhenPassedCommandIsNull()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidUnitCreationCommandException>(() => sut.GetUnit(null));
        }

        [TestMethod]
        public void ReturnNewProcyonUnitWhenProcyonTypeIsPassed()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act
            var procyonUnit = sut.GetUnit("create unit Procyon Pesho 1");

            //Assert
            Assert.IsInstanceOfType(procyonUnit, typeof(Procyon));
        }

        [TestMethod]
        public void ReturnNewLuytenUnitWhenProcyonTypeIsPassed()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act
            var procyonUnit = sut.GetUnit("create unit Luyten Pesho 1");

            //Assert
            Assert.IsInstanceOfType(procyonUnit, typeof(Luyten));
        }

        [TestMethod]
        public void ReturnNewLacailleUnitWhenProcyonTypeIsPassed()
        {
            //Arrange
            var sut = new UnitsFactory();

            //Act
            var procyonUnit = sut.GetUnit("create unit Lacaille Pesho 1");

            //Assert
            Assert.IsInstanceOfType(procyonUnit, typeof(Lacaille));
        }
    }
}
