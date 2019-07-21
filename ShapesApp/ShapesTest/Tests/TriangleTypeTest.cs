using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTest.Tests
{
    [TestClass]
    public class TriangleTypeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(true, triangle.IsRightAngled());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var triangle = new Triangle(4, 4, 3);

            Assert.AreEqual(false, triangle.IsRightAngled());
        }
    }
}
