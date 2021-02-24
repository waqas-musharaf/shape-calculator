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
    class TestQuadratic
    {
        [TestCase]
        // Assume: Fail
        public void Test1()
        {
            double a = 2;
            double b = 5;
            double c = -3;

            Assert.AreEqual("(0, 0)", Quadratic.Solve(a, b, c).Item2);
        }

        [TestCase]
        // Assume: Pass
        public void Test2()
        {
            double a = 2;
            double b = 5;
            double c = -3;

            Assert.AreEqual("(-3, 0.5)", Quadratic.Solve(a, b, c).Item2);
        }

        [TestCase]
        // Assume: Fail
        public void Test3()
        {
            double a = 1;
            double b = 4;
            double c = 5;

            Assert.AreEqual("(0, 0)", Quadratic.Solve(a, b, c).Item2);
        }

        [TestCase]
        // Assume: Pass
        public void Test4()
        {
            double a = 1;
            double b = 4;
            double c = 5;

            Assert.AreEqual("(1, -2)", Quadratic.Solve(a, b, c).Item2);
        }

        [TestCase]
        // Assume: Fail
        public void Test5()
        {
            double a = -3;
            double b = -24;
            double c = -48;

            Assert.AreEqual("(0, 0)", Quadratic.Solve(a, b, c).Item2);
        }

        [TestCase]
        // Assume: Pass
        public void Test6()
        {
            double a = -3;
            double b = -24;
            double c = -48;

            Assert.AreEqual("(-4)", Quadratic.Solve(a, b, c).Item2);
        }
    }
}
