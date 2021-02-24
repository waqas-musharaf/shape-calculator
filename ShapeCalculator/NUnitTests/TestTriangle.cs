using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeCalculator.Classes;

namespace ShapeCalculator.NUnitTests
{
    [TestFixture]
    class TestTriangle
    {
        [TestCase]
        // Assume: Fail
        public void TestGetArea1()
        {
            double a = 2.0d;
            double b = 3.0d;
            double c = 4.0d;

            Assert.AreEqual(12.0000d, Math.Round(Triangle.GetArea(a, b, c)), 4);
        }

        [TestCase]
        // Assume: Pass
        public void TestGetArea2()
        {
            double a = 2.0d;
            double b = 3.0d;
            double c = 4.0d;

            Assert.AreEqual(2.9047d, Math.Round(Triangle.GetArea(a, b, c)), 4);
        }

        [TestCase]
        // Assume: Fail
        public void TestGetPerimeter1()
        {
            double a = 2.0d;
            double b = 3.0d;
            double c = 4.0d;

            Assert.AreEqual(5.0d, Triangle.GetPerimeter(a, b, c));
        }

        [TestCase]
        // Assume: Pass
        public void TestGetPerimeter2()
        {
            double a = 2.0d;
            double b = 3.0d;
            double c = 4.0d;

            Assert.AreEqual(9.0d, Triangle.GetPerimeter(a, b, c));
        }
    }
}
