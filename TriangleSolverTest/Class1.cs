using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void CalculateEquilateralTriangleInput3and3and3OutputValidTriangle()
        {
            int sideA = 3;
            int sideB = 3;
            int sideC = 3;

            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", output);
        }
    }
}
