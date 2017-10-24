using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using reposVector;

namespace VectorUnitTest
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void VectorAddTest()
        {
            Coord coord1 = new Coord(1, 1, 1);
            Coord coord2 = new Coord(2, 2, 2);

            Vector v1 = new Vector(coord1);
            Vector v2 = new Vector(coord2);
           
            Coord expectedCoord = new Coord(3, 3, 3);
            Vector expectedVector = new Vector(expectedCoord);
            Vector resultVector = v1 + v2;

            Assert.AreEqual(expectedVector.v.x, resultVector.v.x);
            Assert.AreEqual(expectedVector.v.y, resultVector.v.y);
            Assert.AreEqual(expectedVector.v.z, resultVector.v.z);
        }

        [TestMethod]
        public void VectorSubTest()
        {
            Coord coord1 = new Coord(1, 1, 1);
            Coord coord2 = new Coord(2, 2, 2);

            Vector v1 = new Vector(coord1);
            Vector v2 = new Vector(coord2);

            Coord expectedCoord = new Coord(-1, -1, -1);
            Vector expectedVector = new Vector(expectedCoord);
            Vector resultVector = v1 - v2;

            Assert.AreEqual(expectedVector.v.x, resultVector.v.x);
            Assert.AreEqual(expectedVector.v.y, resultVector.v.y);
            Assert.AreEqual(expectedVector.v.z, resultVector.v.z);
        }

        [TestMethod]
        public void VectorMulK()
        {
            Coord coord1 = new Coord(1, 1, 1);
            double k = 2;

            Vector v1 = new Vector(coord1);
          
            Coord expectedCoord = new Coord(2, 2, 2);
            Vector expectedVector = new Vector(expectedCoord);
            Vector resultVector = k * v1;

            Assert.AreEqual(expectedVector.v.x, resultVector.v.x);
            Assert.AreEqual(expectedVector.v.y, resultVector.v.y);
            Assert.AreEqual(expectedVector.v.z, resultVector.v.z);
        }

        [TestMethod]
        public void VectorLenTest()
        {
            Coord coord1 = new Coord(1, 1, 1);
            Vector v1 = new Vector(coord1);
          
            double resultLen = v1.VectorLen();
            double expectedLen = 1.7320;

            Assert.AreEqual(expectedLen, resultLen, 0.001);
          
        }
    }
}
