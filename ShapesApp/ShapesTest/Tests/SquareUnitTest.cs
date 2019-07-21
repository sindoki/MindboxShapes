using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace ShapesTest
{
    [TestClass]
    public class SquareUnitTest
    {
        private void PerformTest(int testDataIndex) {
            var calculator = ServiceProvider.GetShapesCalculator();
            var testData = TestDataProvider.ShapesAndSquares[testDataIndex];
            var result = calculator.CalculateShapeSquare(testData.Item1);

            Assert.AreEqual(testData.Item2, result);
        }

        [TestMethod]
        public void TestMethod1()
        {
            PerformTest(0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PerformTest(1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PerformTest(2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            PerformTest(3);
        }

        [TestMethod]
        public void TestMethod5()
        {
            PerformTest(4);
        }

    }
}
