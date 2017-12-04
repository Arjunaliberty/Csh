using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCheckOpAdd()
        {
            /// Создаем два объекта типа MatrixInt
            MatrixInt m1 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });
            MatrixInt m2 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });

            MatrixInt actual = m1 + m2;
            MatrixInt expected = new MatrixInt(new int[,] { { 2, 2 }, { 2, 2 } });
            
            Assert.AreEqual(expected, actual, "Тест не пройден!");
        }

        [TestMethod]
        public void TestMethodCheckSub()
        {
            /// Создаем два объекта типа MatrixInt
            MatrixInt m1 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });
            MatrixInt m2 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });

            MatrixInt actual = m1 - m2;
            MatrixInt expected = new MatrixInt(new int[,] { { 0, 0 }, { 0, 0 } });

            Assert.AreEqual(expected, actual, "Тест не пройден!");
        }

        [TestMethod]
        public void TestMethodCheckMult()
        {
            /// Создаем два объекта типа MatrixInt
            MatrixInt m1 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });
            MatrixInt m2 = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });

            MatrixInt actual = m1 * m2;
            MatrixInt expected = new MatrixInt(new int[,] { { 1, 1 }, { 1, 1 } });

            Assert.AreEqual(expected, actual, "Тест не пройден!");
        }
    }
}
