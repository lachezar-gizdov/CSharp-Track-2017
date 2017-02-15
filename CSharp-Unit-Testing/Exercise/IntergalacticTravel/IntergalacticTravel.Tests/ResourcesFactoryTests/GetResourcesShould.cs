namespace IntergalacticTravel.Tests.ResourcesFactoryTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class GetResourcesShould
    {
        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofGoldSilverBronze()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources gold(20) silver(30) bronze(40)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofGoldBronzeSilver()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources gold(20) bronze(40) silver(30)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofSilverBronzeGold()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources silver(30) bronze(40) gold(20)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofSilverGoldBronze()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources silver(30) gold(20) bronze(40)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofBronzeGoldSilver()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources bronze(40) gold(20) silver(30)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ReturnNewlyCreatedResourcesObjectWithCorrectlAmountsofBronzeSilverGold()
        {
            //Arrange
            var sut = new ResourcesFactory();
            uint gold = 20;
            uint silver = 30;
            uint bronze = 40;

            //Act
            var resources = sut.GetResources("create resources bronze(40) silver(30) gold(20)");

            //Assert
            Assert.AreEqual(gold, resources.GoldCoins);
            Assert.AreEqual(silver, resources.SilverCoins);
            Assert.AreEqual(bronze, resources.BronzeCoins);
        }

        [TestMethod]
        public void ThrowInvalidOperationExceptionWhenPassedCommandIsNull()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => sut.GetResources(null));
        }

        [TestMethod]
        public void ThrowInvalidOperationExceptionWhenPassedCommandIsInvalidCaseTwo()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => sut.GetResources("create resources x y z"));
        }

        [TestMethod]
        public void ThrowInvalidOperationExceptionWhenPassedCommandIsInvalidCaseThree()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => sut.GetResources("tansta resources a b"));
        }

        [TestMethod]
        public void ThrowInvalidOperationExceptionWhenPassedCommandIsInvalidCaseFour()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => sut.GetResources("absolutelyRandomStringThatMustNotBeAValidCommand"));
        }

        [TestMethod]
        public void ThrowOverflowExceptionWhenWhenGoldAmountExceedsTheLimit()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<OverflowException>(() => sut.GetResources("create resources gold(4294967296) silver(30) bronze(40)"));
        }

        [TestMethod]
        public void ThrowOverflowExceptionWhenWhenSilverAmountExceedsTheLimit()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<OverflowException>(() => sut.GetResources("create resources gold(20) silver(4294967296) bronze(40)"));
        }

        [TestMethod]
        public void ThrowOverflowExceptionWhenWhenBronzeAmountExceedsTheLimit()
        {
            //Arrange
            var sut = new ResourcesFactory();

            //Act & Assert
            Assert.ThrowsException<OverflowException>(() => sut.GetResources("create resources gold(20) silver(30) bronze(4294967296)"));
        }
    }
}
