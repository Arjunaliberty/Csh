using System;
using Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductClass product = new ProductClass("test", 100, 50);
            double excpected = 50;
            double actual = product.PriceDiscount();

            Assert.AreEqual(excpected, actual);
        }
    }
}
