using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleSquareMethod()
        {
            //Arrange
            double expected = 3.14;
            double actual;
            //Act
            actual = ClassLibraryTest.Geometry.Square(1);
            //Assert
            Assert.AreEqual(expected, actual, 0.09);
        }
        [TestMethod]
        public void TestRectangleSquareMethod()
        {
            //Arrange
            double expected = 6;
            double actual;
            //Act
            actual = ClassLibraryTest.Geometry.Square(3, 4, 5);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
