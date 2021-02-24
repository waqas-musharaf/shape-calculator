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
    class TestCircle
    {
        [TestCase]
        // Assume: Fail
        public void TestGetArea1()
        {
            double radius = 2.0d;
            Assert.AreEqual(2 * Math.PI, Circle.GetArea(radius));
        }

        [TestCase]
        // Assume: Pass
        public void TestGetArea2()
        {
            double radius = 1.0d;
            Assert.AreEqual(Math.PI, Circle.GetArea(radius));
        }

        [TestCase]
        // Assume: Fail
        public void TestGetPerimeter1()
        {
            double radius = 2.0d;
            Assert.AreEqual(4 * Math.PI * radius, Circle.GetPerimeter(radius));
        }
        
        [TestCase]
        // Assume: Pass
        public void TestGetPerimeter2()
        {
            double radius = 1.0d;
            Assert.AreEqual(2 * Math.PI * radius, Circle.GetPerimeter(radius));
        }
    }
}
