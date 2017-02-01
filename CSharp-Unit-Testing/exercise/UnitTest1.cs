using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsItCalculatingProperly()
        {
            var largest = new GetLargestNumber();
            var array = new int[] { 5, 10, 15 };

            Assert.AreEqual(15, largest.GetMax(array));
        }

        //[TestMethod]
        //public void AreAllNumbers()
        //{
        //    var largest = new GetLargestNumber();
        //    var array = new string[] { "one", "two", "ten" };

        //    Assert.IsTrue(array.GetType().GetElementType() == typeof(int));
        //}
    }
}
