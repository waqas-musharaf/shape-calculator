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
    class TestSquare
    {
        [TestCase]
        // Assume: Fail
        public void TestGetArea1()
        {
            double length = 5.0d;
            Assert.AreEqual(50.0d, Square.GetArea(length));
        }

        [TestCase]
        // Assume: Pass
        public void TestGetArea2()
        {
            double length = 5.0d;
            Assert.AreEqual(25.0d, Square.GetArea(length));
        }

        [TestCase]
        // Assume: Fail
        public void TestGetPerimeter1()
        {
            double length = 5.0d;
            Assert.AreEqual(25.0d, Square.GetPerimeter(length));
        }

        [TestCase]
        // Assume: Pass
        public void TestGetPerimeter2()
        {
            double length = 5.0d;
            Assert.AreEqual(20.0d, Square.GetPerimeter(length));
        }
    }
}
